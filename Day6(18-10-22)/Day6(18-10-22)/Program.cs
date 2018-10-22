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
        //서버에서 불특정하게 날아오는 다른 Client가 쓴 내용을
        //받기 위해 클라이언트의 글읽는 부분을 쓰레드로 처리
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
            StreamReader reader = null;
            try
            {
                client = new TcpClient(); //1. 소켓 생성
                client.Connect("192.168.0.15", 5001); // 2. connect
                NetworkStream stream = client.GetStream(); // 3. 스트림 생성
                StreamWriter writer = new StreamWriter(stream) { AutoFlush = true };
                // 4. 글을 쓰려면  StreamWriter


                ServerHandler serverHandler = new ServerHandler(reader);
                Thread t = new Thread(new ThreadStart(serverHandler.chat));
                t.Start();


                string dataToSend = Console.ReadLine();

                Encoding encode = Encoding.GetEncoding("utf-8");
                reader = new StreamReader(stream, encode);

                while (true)
                {
                    writer.WriteLine(dataToSend);
                    string str = reader.ReadLine();
                    Console.WriteLine(str);

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
