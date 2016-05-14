using System;
using System.Collections.Generic;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting;
using ISuper;
using System.Runtime.Remoting.Channels.Http;

namespace Zone
{
    class Program
    {
        static List<StockManager> managers;
        static void Main(string[] args)
        {
            managers = null;
            HttpChannel ch = new HttpChannel(1234);
            ChannelServices.RegisterChannel(ch, false);
            RemotingConfiguration.RegisterWellKnownServiceType(
                typeof(StockManager),
                "Stock1.xml",
                WellKnownObjectMode.Singleton
            );
            Console.WriteLine("Waiting Request...");
        }
        static void Register(StockManager sm)
        {

        }
        static void Unregister()
        {

        }
        static void LoadStock()
        {

        }
    }
}
