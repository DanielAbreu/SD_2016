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
        private IZone nextZone;

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
            nextZone = (IZone)Activator.GetObject(typeof(IZone),
                                                  string.Format("{0}/{1}",
                                                  string.Format("http://localhost:", nextZonePort), "zone"));
        }

        public void Register(IStockManager stockManager, Item[] stock)
        {
            Console.WriteLine("Registed entered");
            if (managers.Contains(stockManager))
            {
                return;
            }

            managers.Add(stockManager);
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

            nextZone.Register(stockManager, stock);
            Console.WriteLine("Successfully Registed the StockManager");
        }
        public void Unregister(IStockManager stockManager)
        {
            Console.WriteLine("Registed entered");
            if (!managers.Contains(stockManager))
            {
                return;
            }

            managers.Remove(stockManager);

            nextZone.Unregister(stockManager);
            Console.WriteLine("Successfully Unregisted the StockManager");
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
