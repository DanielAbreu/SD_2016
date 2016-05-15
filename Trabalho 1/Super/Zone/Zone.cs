using ISuper;
using ISuperInterfaces;
using System;
using System.Collections.Generic;
using System.Configuration;

namespace Zone
{
    public class Zone : MarshalByRefObject, IZone
    {
        private List<IStockManager> managers;
        private Dictionary<string, List<Item>> stockCache;

        private int nextZonePort
        {
            get
            {
                if (ConfigurationManager.AppSettings["nextPort"] == null)
                {
                    throw new ArgumentNullException("Key nextPort not present in App.config");
                }
                return Int32.Parse(ConfigurationManager.AppSettings["nextPort"]);
            }
        }

        public Zone()
        {
            managers = new List<IStockManager>();
            stockCache = new Dictionary<string, List<Item>>();
        }

        public void Register(IStockManager stockManager, IEnumerable<Item> stock)
        {
            if (managers.Contains(stockManager))
            {
                return;
            }

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

            IZone nextZone = (IZone)Activator.GetObject(typeof(IZone),
                                                  string.Format("{0}/{1}",
                                                  string.Format("http://localhost:", nextZonePort), "zone"));

            nextZone.Register(stockManager, stock);
            Console.WriteLine("Successfully Registed the StockManager");
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
