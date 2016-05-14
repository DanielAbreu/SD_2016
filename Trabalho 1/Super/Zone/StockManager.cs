using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Runtime.Remoting.Channels.Http;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting;
using Zone;
using ISuperInterfaces;

namespace ISuper
{
    public class StockManager : MarshalByRefObject, IStockManager
    {
        public Program zo;

        public IEnumerable<Item> GetLocalStock(string it)
        {
            return zo.LoadStock(it);
        }

        public IEnumerable<Item> GetRemoteStock(string it)
        {
            HttpChannel ch = new HttpChannel(1234);
            ChannelServices.RegisterChannel(ch, false);
            RemotingConfiguration.RegisterWellKnownServiceType(
                typeof(StockManager),
                "Stock1.xml",
                WellKnownObjectMode.Singleton
            );
            return null;
        }
    }
}
