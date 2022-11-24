using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP
{
    public class NetworkBandwidth
    {
        public virtual void networkBandwidth(int bandWidth)
        {
            Console.WriteLine("The network bandwidth is: " + bandWidth);
        }

        public virtual void networkPing()
        {
            Console.WriteLine("Ping is Higher in this network");
        }
    }

    public class IncreasedNetworkBandwidth : NetworkBandwidth {
        public override void networkBandwidth(int bandWidth)
        {
            int increasedNetworkbandwidth = bandWidth + bandWidth;
            Console.WriteLine("The network bandwidth can be increased to " + increasedNetworkbandwidth + " mbps");
        }

        public override void networkPing()
        {
            Console.WriteLine("Ping is Lower in this network");
        }
    }
}
