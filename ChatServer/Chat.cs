using Classes;
using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;

namespace ChatServer
{
    public class Chat
    {
        #region Variables

        private static DBChat _ChatDB;
        private static List<string> _NickNames;
        private static readonly object _IsConnectedLock;
        private TcpListener _ChatServer;
        private BinaryFormatter _BinaryFormatter = new BinaryFormatter();
        Communication _CommManager;

        #endregion

        #region Properties

        public static Dictionary<User, TcpClient> _ConnectedUsers { get; set; }

        #endregion

        #region Constructor

        static Chat()
        {
            _IsConnectedLock = new object();
            _ChatDB = new DBChat();
        }

        #endregion

        #region Methods

        public void Init()
        {
            Thread userConnectionThread = new Thread(CheckUsersConnection)
            {
                IsBackground = true
            };
            userConnectionThread.Start();

            _ConnectedUsers = new Dictionary<User, TcpClient>();
            _NickNames = new List<string>();

            _ChatServer = new TcpListener(
                IPAddress.Parse(Properties.Settings.Default.IP_ADDRESS),
                Properties.Settings.Default.PORT
            );
            _ChatDB.CheckAllConnections();
            while (true)
            {
                _ChatServer.Start();
                if (_ChatServer.Pending())
                {
                    TcpClient chatConnection = _ChatServer.AcceptTcpClient();
                    _CommManager = new Communication(chatConnection, _ChatDB);
                    _CommManager.UserAdded += Comm_UserAdded;
                }
            }
        }

        private void CheckUsersConnection()
        {
            lock (_IsConnectedLock)
            {
                while (true)
                {
                    try
                    {
                        foreach (var user in _ConnectedUsers.Where(x => !x.Value.Connected))
                        {
                            OnUserDisconnected(user.Key);
                            _ConnectedUsers.Remove(user.Key);
                            SendRemoveUserPacket(user.Key);
                            _ChatDB.DisconnectUser(user.Key.Id);
                        }
                    }
                    catch (Exception)
                    {
                        continue;
                    }
                }
            }
        }

        private void SendRemoveUserPacket(User user)
        {
            Packet packet = new Packet()
            {
                Type = TypeData.REMOVE_USER,
                Message = string.Format("SERVER SAYS:\r\n\t{0} HAS LEFT THE CHAT", user.NickName.ToUpper()),
                User = user,
            };
            SendMsgToAll(packet);
        }

        public static void SendMsgToAll(Packet packet)
        {
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            TcpClient[] tcpClient = new TcpClient[_ConnectedUsers.Count];

            //copy the users nickname to the ChatServer values
            _ConnectedUsers.Values.CopyTo(tcpClient, 0);

            if (string.IsNullOrWhiteSpace(packet.Message))
            {
                return;
            }

            for (int i = 0; i < tcpClient.Length; i++)
            {
                if (tcpClient[i] == null)
                {
                    continue;
                }

                NetworkStream networkStream = tcpClient[i].GetStream();
                binaryFormatter.Serialize(networkStream, packet);
            }
        }

        public List<User> GetUsers()
        {
            List<User> users = _ChatDB.GetUsers();
            return users;
        }

        public List<Message> GetMessages()
        {
            List<Message> messages = _ChatDB.GetMessages();
            return messages;
        }

        internal static void SendMsgToPrivate(User user, Packet p)
        {
            BinaryFormatter binaryFormatter = new BinaryFormatter();

            //send a message to the user who sent it
            var selfClient = _ConnectedUsers.Where(x => x.Key.Id == user.Id).Select(x => x.Value).First();
            NetworkStream networkStream = selfClient.GetStream();
            Packet packet = new Packet()
            {
                Type = TypeData.MESSAGE,
                Message = "(PRIVATE MESSAGE) " + user.NickName + ": " + p.Message,
                Color = p.Color
            };
            binaryFormatter.Serialize(networkStream, packet);

            //send a message to the recepient
            for (int i = 0; i < p.UsersList.Count; i++)
            {
                var recepientClient = _ConnectedUsers.Where(x => x.Key.Id == p.UsersList[i].Id).Select(x => x.Value).First();
                networkStream = recepientClient.GetStream();
                packet = new Packet()
                { Type = TypeData.MESSAGE, Message = "(PRIVATE MESSAGE) " + user.NickName + ": " + p.Message, Color = p.Color };
                binaryFormatter.Serialize(networkStream, packet);
            }
        }

        /// <summary>
        /// Sends the new client the list of connected users. in addition sends all the connected clients the new client.  
        /// </summary>
        /// <param name="newUser"></param>
        /// <param name="networkStream"></param>
        public static void SendUsersList(User newUser, NetworkStream networkStream)
        {
            TcpClient[] tcpClient = new TcpClient[_ConnectedUsers.Count];
            //copy the users nickname to the ChatServer values
            _ConnectedUsers.Values.CopyTo(tcpClient, 0);

            BinaryFormatter binaryFormatter = new BinaryFormatter();
            Packet packet = new Packet();
            packet.Type = TypeData.USERS_INIT;
            packet.UsersList = _ConnectedUsers.Keys.ToList();
            binaryFormatter.Serialize(networkStream, packet);

            for (int i = 0; i < _ConnectedUsers.Count; i++)
            {
                if (networkStream != tcpClient[i].GetStream())
                {
                    NetworkStream ns2 = tcpClient[i].GetStream();
                    packet.Type = TypeData.ADD_USER;
                    packet.User = newUser;
                    binaryFormatter.Serialize(ns2, packet);
                }
            }
        }

        #endregion

        #region Event Handlers

        private void Comm_UserAdded(User user)
        {
            OnUserAdded(user);
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

        public delegate void UserDisconnectedDelegate(User user);
        public event UserDisconnectedDelegate UserDisconnected;
        private void OnUserDisconnected(User user)
        {
            if (UserDisconnected == null) return;
            UserDisconnected.Invoke(user);
        }

        #endregion
    }
}
