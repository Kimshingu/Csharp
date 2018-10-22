using System;
using System.IO;
using System.Text;
using System.Net;
using System.Net.Sockets;


namespace Server
{
    class Server
    {
        static void Main(string[] args)
        {
            NetworkStream stream = null;
            TcpListener tcpListener = null;
            Socket clientsocket = null;
            StreamReader reader = null;
            StreamWriter writer = null;
           
            try
            {
                IPAddress ipAd = IPAddress.Parse("192.168.0.213"); //1.자신의 ip

                tcpListener = new TcpListener(ipAd, 5001); //2.서버 소켓(ip,port)
                tcpListener.Start(); //3.서버 실행

                clientsocket = tcpListener.AcceptSocket(); 
                // 홀딩되고 있다. 클라이언트의 요청을 기다린다.
                // 소켓이 만들어진다. !!Socket!! clientsocket

                stream = new NetworkStream(clientsocket); // 4. network stream 생성
                Encoding encode = Encoding.GetEncoding("utf-8"); // utf-8 인코딩

                reader = new StreamReader(stream, encode); // 5. 한 라인씩 들어감

                writer = new StreamWriter(stream) { AutoFlush = true };
                // 서버가 클라이언트에게 보내고 싶다면 StreamWriter 코드가 들어가면 된다.

                while (true)
                {
                    string str = reader.ReadLine();
                    Console.WriteLine(str);

                    writer.WriteLine(str);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            finally
            {
                clientsocket.Close();
            }

        }
    }
}
