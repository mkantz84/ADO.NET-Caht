using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Net;
using System.Net.Sockets;
using System.Drawing;
using System.Threading;

namespace Classes
{
    public class Class1
    {
    }
    [Serializable]
    public class User
    {
        Thread thread;
        public string IPAddress { get; set; }
        public int Port { get; set; }
        public string NickName { get; set; }
        public Color UserColor { get; set; }
        Socket sck;
        TcpClient client;
        public User()
        {

        }

        public User(TcpClient accepted)
        {
            client = accepted;
            //IPAddress = (IPEndPoint)sck.RemoteEndPoint; //Check this
            thread = new Thread();
        }
        public User(Socket accepted)
        {
            sck = accepted;
            //IPAddress = (IPEndPoint)sck.RemoteEndPoint; //Check this
            sck.BeginReceive
                (new byte[] { 0 }, 0, 0, 0, callback, null);
        }
        void callback(IAsyncResult ar)
        {
            try
            {
                sck.EndReceive(ar);
                byte[] buf = new byte[8192];
                int rec = sck.Receive(buf, buf.Length, 0);
                if (rec < buf.Length)
                    Array.Resize(ref buf, rec);
                Recieved?.Invoke(this, buf);
                sck.BeginReceive
                (new byte[] { 0 }, 0, 0, 0, callback, null);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Close();
                Disconnected?.Invoke(this);
            }
        }
        public void Close()
        {
            sck.Close();
            sck.Dispose();
        }
        public override string ToString()
        {
            return string.Format("{0}", NickName);
        }
        public delegate void CliendRecievedHandler(User sender, byte[] data);
        public delegate void CliendDisconnectedHandler(User sender);

        public event CliendRecievedHandler Recieved;
        public event CliendDisconnectedHandler Disconnected;
    }



    public class Listener
    {
        //Socket s;

        TcpListener listener;
        Thread thread;
        public bool Listening { get; set; }
        public int Port { get; set; }
        public Listener(int port)
        {
            Port = port;
            listener = new TcpListener(IPAddress.Parse("127.0.0.1"), port);

            //s = new Socket
            //    (AddressFamily.InterNetwork,
            //    SocketType.Stream,
            //    ProtocolType.Tcp);
        }
        public void Start()
        {
            if (Listening)
                return;
            listener.Start();
            thread = new Thread(callback);
            thread.IsBackground = true;
            thread.Start();
            //s.Bind(new IPEndPoint(IPAddress.Parse("127.0.0.1"), Port));
            //s.Listen(0);
            //s.BeginAccept(callback, null);
            Listening = true;
        }

        
        public void Stop()
        {
            if (!Listening)
                return;
            listener.Stop();
            listener = new TcpListener(IPAddress.Parse("127.0.0.1"), Port);

            //s.Close();
            //s.Dispose();
            //s = new Socket
            //    (AddressFamily.InterNetwork,
            //    SocketType.Stream,
            //    ProtocolType.Tcp);
        }
        public void callback()
        {
            try
            {
                TcpClient client = listener.AcceptTcpClient();
                ClientAccept?.Invoke(client);
                thread = new Thread(callback);
                thread.Start();

                //Socket s = this.s.EndAccept(ar);
                //SocketAccepted?.Invoke(s);
                //this.s.BeginAccept(callback, null);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public delegate void ClientAcceptedHandler(TcpClient client);
        public event ClientAcceptedHandler ClientAccept;

        //public delegate void SocketAcceptedHandler(Socket e);
        //public event SocketAcceptedHandler SocketAccepted;
    }
}
