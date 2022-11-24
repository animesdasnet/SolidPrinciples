using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP
{
    public class InternetServiceProvider
    {
        public void InternetSubscriberId(int subscriberId) {
            Console.WriteLine(subscriberId);
        }

        public void InternetSubscriberName(string subscriberName)
        {
            Console.WriteLine(subscriberName);
        }
    }

    public class NetworkSpeed
    {
        public void InternetSpeed(int netSpeed)
        {
            Console.WriteLine(netSpeed + " mbps");
        }
    }
}
