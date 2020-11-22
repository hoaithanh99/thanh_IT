using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace client_sapxeptangdan
{
    class Program
    {
        private const int PORT_NUMBER = 9999;
        static void Main(string[] args)
        {
            try
            {
                TcpClient client = new TcpClient();
                client.Connect("127.0.0.1", PORT_NUMBER);
                Stream stream = client.GetStream();
                while (true)
                {
                    Console.Write("Nhap vao mot day so (moi so cach nhau boi 1 khoang trang): ");
                    string str = Console.ReadLine();
                    var reader = new StreamReader(stream);
                    var writer = new StreamWriter(stream);
                    writer.AutoFlush = true;
                    writer.WriteLine(str);
                    str = reader.ReadLine();
                    if (str == "exit") break;
                    Console.WriteLine(str);
                }
                stream.Close();
                client.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex);
            }
            Console.Read();
        }

    }
}
