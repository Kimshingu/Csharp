using System;
using System.IO;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace my_server_code
{
    class Program
    {
        static void Main(string[] args)
        {
            TcpListener listener = null;
            Socket socket = null;

            IPAddress id = IPAddress.Parse("192.168.0.213");
            listener = new TcpListener(id, 5001);
            listener.Start();

            while (true)
            {


            }

        }
    }
}
