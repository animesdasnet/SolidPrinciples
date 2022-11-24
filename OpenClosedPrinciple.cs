using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP
{
    public abstract class BlockedWebsites 
    {
        public abstract void WebsiteName();
    }

    public class BlockedUrl: BlockedWebsites
    {
        public override void WebsiteName()
        {
            Console.WriteLine("Google.com is blocked");
;        }
    }
}
