using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP
{
    public interface NetworkPacketData {
        public void PacketDataRate();
    }

    public class PacketData : NetworkPacketData
    {
        public void PacketDataRate()
        {
            Console.WriteLine("The packet data rate is higher compared to other networks");
        }
    }

    public class DataRate {
        private readonly NetworkPacketData _packetData;
        public DataRate(NetworkPacketData PacketData)
        {
            _packetData = PacketData;
        }

        public void PacketDataRate()
        {
            _packetData.PacketDataRate();
        }
    }


}
