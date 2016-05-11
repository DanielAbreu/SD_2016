using IZone;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ISuper
{
    public class StockManager : MarshalByRefObject, IStockManager
    {
        public IEnumerable<Item> GetLocalStock()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Item> GetRemoteStock()
        {
            throw new NotImplementedException();
        }
    }
}
