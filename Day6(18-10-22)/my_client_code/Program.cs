using System;
using System.IO;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace my_client_code
{
    class Program
    {
        static void Main(string[] args)
        {
            TcpClient client = null;
            StreamWriter writer = null;


            try
            {
                client = new TcpClient();
                client.Connect("192.168.0.213", 5001);
                Stream stream = client.GetStream();
                writer = new StreamWriter(stream) { AutoFlush = true };

                string str = Console.ReadLine();

                while (true)
                {
                    writer.WriteLine(str);
                    str = Console.ReadLine();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                client.Close();
            }
            
        }
    }
}
