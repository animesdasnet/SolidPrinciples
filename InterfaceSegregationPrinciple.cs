using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP
{
    public interface INetworkDetails
    {
        void NetworkId();
        void NetworkName();
    }

    public interface INetworkPing
    {
        void InternetNetworkPing();
    }

    public class NetworkPing : INetworkPing
    {
        public void InternetNetworkPing()
        {
            Console.WriteLine("Ping rate can be conrolled");
        }
    }

    public class NetworkDetails : INetworkDetails { 
        public void NetworkId()
        {
            Console.WriteLine("Network ID : 331");
        }

        public void NetworkName()
        {
            Console.WriteLine("Network Name: JioFiber");
        }
    }


}
