using System;
using System.Collections.Generic;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Http;
using System.Runtime.Remoting;
using ISuper;
using System.Collections;
using ISuperInterfaces;
using System.Configuration;

namespace Zone
{
    public class Program
    {
        static int port
        {
            get
            {

                if (ConfigurationManager.AppSettings["port"] == null)
                {
                    throw new ArgumentNullException("Key port not present in App.config");
                }
                return Int32.Parse(ConfigurationManager.AppSettings["port"]);
            }
        }

        static void Main(string[] args)
        {
            HttpChannel ch = new HttpChannel(port);
            ChannelServices.RegisterChannel(ch, false);
            RemotingConfiguration.RegisterWellKnownServiceType(
                typeof(Zone),
                "zone.soap",
                WellKnownObjectMode.Singleton
            );

            RemotingConfiguration.RegisterWellKnownServiceType(
                typeof(StockManager),
                "stockmanager.soap",
                WellKnownObjectMode.SingleCall
            );

            Console.WriteLine("Waiting Requests on port: "+port);
            Console.ReadLine();
        }
    }
}
