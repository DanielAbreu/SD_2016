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
        public IZone zone { get; set; }

        public IEnumerable<Item> GetLocalStock(string it)
        {
            return zone.GetItemStock(it);
        }

        public IEnumerable<Item> GetRemoteStock(string it)
        {
            IZone curr = zone;
            IEnumerable<Item> res = null;
            int startingPort = zone.port;
            IZone next = null;
            while (next.port != startingPort)
            {
                if (ConfigurationManager.AppSettings["nextPort"] == null) break;
                string nextPort = ConfigurationManager.AppSettings["nextPort"];
                next = (IZone)Activator.GetObject(typeof(IZone), 
                                                  string.Format("{0}/{1}", 
                                                  string.Format("http://localhost:", nextPort), "zone"));
                zone = next;
                if ((res = zone.GetItemStock(it)) != null) break;
            }
            curr = zone;
            if (res == null)
            {
                Console.WriteLine("Couldn't retrieve stocks for" + it + " remotely");
                return null;
            }
            else
            {
                Console.WriteLine("Successfully retrieved stocks remotely for " + it);    
                return res;
            }
        }
    }
}
