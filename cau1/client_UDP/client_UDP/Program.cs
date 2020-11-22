using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace client_UDP
{
    class Program
    {
        static void Main(string[] args)
        {
            string _host = "127.0.0.1";
            int _port = 2008;
            UdpClient udp = new UdpClient();
            udp.Connect(_host, _port);
            bool isConnect = true;
            while (isConnect)
            {
                {
                    Console.Write("Nhap noi dung gui toi Server: ");
                    string str = Console.ReadLine();
                    if (str == "exit") return;
                    Byte[] data = Encoding.ASCII.GetBytes(str);
                    udp.Send(data, data.Length);
                }
                Console.ReadLine();
            }
        }
    }
}
