using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace server_UDP
{
    class Program
    {
        static void Main(string[] args)
        {
            UdpClient udp = new UdpClient(2008);
            while (true)
            {
                {
                    IPEndPoint RemoteIPEndPoint = new IPEndPoint(IPAddress.Any, 0);
                    Byte[] data = udp.Receive(ref RemoteIPEndPoint);
                    string message = Encoding.ASCII.GetString(data);
                    Console.WriteLine("Address: {0} - Message: {1}", RemoteIPEndPoint.Address, message);
                }

            }
        }
    }
}
