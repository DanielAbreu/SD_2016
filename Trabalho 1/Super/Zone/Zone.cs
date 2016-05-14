using ISuper;
using ISuperInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zone
{
    public class Zone : MarshalByRefObject, IZone
    {
        private List<IStockManager> managers;
        private Dictionary<string, List<Item>> stockCache;

        public Zone()
        {
            managers = new List<IStockManager>();
            stockCache = new Dictionary<string, List<Item>>();
        }

        public void Register(IStockManager stockManager, IEnumerable<Item> stock)
        {
            managers.Add(stockManager);
            stockManager.zone = this;
            foreach (Item it in stock)
            {
                if (stockCache.ContainsKey(it.Name))
                {

                    List<Item> li = stockCache[it.Name];
                    li.Add(it);
                    stockCache[it.Name] = li;
                }
                else
                {
                    stockCache.Add(it.Name, new List<Item> { it });
                }
            }
        }
        public void Unregister(IStockManager stockManager)
        {
            stockManager.zone = null;
            managers.Remove(stockManager);
        }

        public IEnumerable<Item> GetItemStock(string name)
        {
            if (stockCache.ContainsKey(name))
            {
                return stockCache[name];
            }
            return null; 
        }
    }
}
