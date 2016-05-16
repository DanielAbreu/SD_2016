using ISuperInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ISuper;

namespace Super
{
    public class StockManager : MarshalByRefObject, IStockManager
    {
        public SuperStock stock;
        public StockManager(SuperStock st)
        {
            this.stock = st;
        }

        public IEnumerable<Item> GetSuperStock()
        {
            return stock.Stock;
        }

        public string IsAlive(string i)
        {
            return i + "done";
        }
    }
}
