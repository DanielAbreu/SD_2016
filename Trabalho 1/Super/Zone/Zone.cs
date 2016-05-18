using ISuper;
using ISuperInterfaces;
using Super;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;

namespace Zone
{
    public class Zone : MarshalByRefObject, IZone
    {
        private List<IStockManager> managers;
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
            nextZone = (IZone)Activator.GetObject(typeof(IZone),
                                                  string.Format("{0}/{1}",
                                                  string.Format("http://localhost:", nextZonePort), "zone"));
        }

        public void Register(IStockManager stockManager, string[] families)
        {
            Console.WriteLine("Register entered");
            if (managers.Contains(stockManager))
            {
                return;
            }
            
            managers.Add(stockManager);

            UpdateManagers(stockManager);
            nextZone.Register(stockManager, families);
            Console.WriteLine("Successfully Registed the StockManager");
        }
        public void Unregister(IStockManager stockManager)
        {
            Console.WriteLine("Unregister entered");
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
            Console.WriteLine("Entered the search for object " + name);
            int retrieved = 0;
            foreach(StockManager sm in managers)
            {
                foreach(Item it in sm.stock.Stock)
                {
                    if (it.Name.Equals(name))
                    {
                        retrieved++;
                        yield return it;
                    }
                }
            }
            if (retrieved > 0) Console.WriteLine("Sucessfully retrieved " + retrieved + "items with that name");
            else Console.WriteLine("Couldn't retrieve any item with that name");
            yield break;
        }

        public string isAlive(string n)
        {
            return n+"done";
        }

        public void UpdateManagers(IStockManager sm)
        {
            foreach(StockManager manager in managers)
            {
                if (manager.managers.Contains(sm)) continue;
                manager.managers.Add(sm);
            }
        }
    }
}
