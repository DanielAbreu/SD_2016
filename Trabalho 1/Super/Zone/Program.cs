using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Http;
using System.Runtime.Remoting;
using Super;

namespace Zone
{
    class Program
    {
        static void Main(string[] args)
        {
            HttpChannel ch = new HttpChannel(1234);
            ChannelServices.RegisterChannel(ch, false);
            RemotingConfiguration.RegisterWellKnownServiceType(
                typeof(StockManager),
                "Stocks.xml",
                WellKnownObjectMode.Singleton
            );
            Console.WriteLine("Waiting Request...");
        }
    }
}
