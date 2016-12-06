using System;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;
using Classes;
using DAL;

namespace ChatServer
{
    class Communication
    {
        #region Variables

        private NetworkStream _NetworkStream;
        private TcpClient _Client;
        private User _User;
        private BinaryFormatter _BinaryFormatter = new BinaryFormatter();
        private DBChat _ChatDB;
        private Thread chatThread;

        #endregion

        #region Constructor
       
        public Communication(TcpClient tcpClient,DBChat chatDb)
        {
            _Client = tcpClient;
            _ChatDB = chatDb;
            chatThread = new Thread(StartChat) { IsBackground = true };
            chatThread.Start();
        }
        #endregion

        #region Methodes

        private void runChat()
        {
            OnUserAdded(_User);
            NetworkStream networkStream = _Client.GetStream();

            try
            {
                while (true)
                {
                    Packet packet = (Packet)_BinaryFormatter.Deserialize(networkStream);
                    HandleData(packet);
                }
            }
            catch (Exception)
            {
                networkStream.Close();
            }
        }
       
        private void HandleData(Packet packet)
        {
            switch (packet.Type)
            {
                case TypeData.MESSAGE:
                    Chat.SendMsgToAll(packet);
                    _ChatDB.AddMessage(packet.MessageText, _User);
                    break;
                case TypeData.PRIVATE_MESSAGE:
                    Chat.SendMsgToPrivate(_User, packet);
                    _ChatDB.AddPrivateMessage(_User, packet.Message,packet.UsersList);
                    break;
            }
        }
        
        /// <summary>
        /// inserts/ checks user in db.
        /// </summary>
        /// <param name="user"></param>
        /// <param name="networkStream"></param>
        private void SendNewId(User user, NetworkStream networkStream)
        {
            Packet packet = new Packet()
            {
                Type = TypeData.GET_ID,
                User = _ChatDB.InsertNewUser(user),
            };
            _User = packet.User;
            _BinaryFormatter.Serialize(networkStream, packet);
        }

        private void StartChat()
        {
            _NetworkStream = _Client.GetStream();
            _User = (User)_BinaryFormatter.Deserialize(_NetworkStream);
            SendNewId(_User, _NetworkStream);
            if (_User.Id != -2)
            {
                SendWelcomeMessage();
                //create a new thread for this user:
                Thread chatThread = new Thread(new ThreadStart(runChat));
                chatThread.Start();
            }
            else
            {
                _Client.Close();
                _NetworkStream.Close();
            }
        }
       
        /// <summary>
        /// Sends welcome message to new users, or "welcome back" messagge to returning users
        /// </summary>
        /// <returns></returns>
        private void SendWelcomeMessage()
        {
            Packet packet;
            if (_User.LastConnectedDate.Year == 0001)
            {
                packet = new Packet
                {
                    Type = TypeData.MESSAGE,
                    Message = "\t\t" + _User.NickName.ToUpper() + "! WELCONE TO CHAT!",
                    IsExists = false,
                };
            }
            else
            {
                packet = new Packet
                {
                    Type = TypeData.MESSAGE,
                    Message = "\t\t" + _User.NickName.ToUpper() + "! WELCONE BACK TO CHAT!",
                    IsExists=true,
                };
            }
            _BinaryFormatter.Serialize(_NetworkStream, packet);

            Chat._ConnectedUsers.Add(_User, _Client);
            Chat.SendUsersList(_User, _NetworkStream);

            packet = new Packet
            {
                Type = TypeData.MESSAGE,
                Message = "SERVER SAYS:\r\n\t" + _User.NickName.ToUpper() + " HAS JOINED THE CHAT"
            };

            Chat.SendMsgToAll(packet);
        }

        #endregion

        #region Events

        public delegate void InsertSuerDelegate(User user);
        public event InsertSuerDelegate UserAdded;
        private void OnUserAdded(User user)
        {
            if (UserAdded == null) return;
            UserAdded.Invoke(user);
        }

        #endregion
    }
}
