using System;
using System.IO;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Threading;
namespace Client
{
    class ServerHandler
    {
        StreamReader reader = null;
        public ServerHandler(StreamReader reader)
        {
            this.reader = reader;
        }

        public void chat()
        {
            try
            {
                while (true)
                {
                    Console.WriteLine(reader.ReadLine());
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
    }

    class Client
    {
        static void Main(string[] args)
        {
            TcpClient client = null;
            try
            {
                client = new TcpClient(); //1. 소켓 생성
                client.Connect("192.168.0.15", 5001); // 2. connect
                NetworkStream stream = client.GetStream(); // 3. 스트림 생성
                StreamWriter writer = new StreamWriter(stream) { AutoFlush = true };
                // 4. 글을 쓰려면  StreamWriter

                Encoding encode = Encoding.GetEncoding("utf-8");
                StreamReader reader = new StreamReader(stream, encode);

                ServerHandler serverHandler = new ServerHandler(reader);
                Thread t = new Thread(new ThreadStart(serverHandler.chat));
                t.Start();


                string dataToSend = Console.ReadLine();

                while (true)
                {
                    writer.WriteLine(dataToSend);

                    if (dataToSend.IndexOf("<EOF>") > -1) break; 
                    // 글을 그만 보내고 싶다면 <EOF>
                    dataToSend = Console.ReadLine();
                }
            }

            catch (Exception ex){
                Console.WriteLine(ex.ToString());
            }
            finally {
                client.Close();
            }
        }
    }
}
