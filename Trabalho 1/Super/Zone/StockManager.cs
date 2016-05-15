using ISuperInterfaces;
using System;
using System.Collections.Generic;

namespace ISuper
{
    public class StockManager : MarshalByRefObject, IStockManager
    {
        public IZone zone { get; set; }

        public IEnumerable<Item> GetStock(string it)
        {
            return zone.GetItemStock(it);
        }
    }
}
