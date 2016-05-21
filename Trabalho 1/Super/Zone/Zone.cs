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

        public void Register(IStockManager stockManager)
        {
            Console.WriteLine("Register entered");
            if (managers == null) managers = new List<IStockManager>();
            
            if (managers.Contains(stockManager))
            {
                return;
            }
            managers.Add(stockManager);
            AddToManagers(stockManager);
            Console.WriteLine(nextZone.isAlive("vive"));
            nextZone.Register(stockManager);
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
            RemoveFromManagers(stockManager);
            nextZone.Unregister(stockManager);
            Console.WriteLine("Successfully Unregisted the StockManager");
        }

        public string isAlive(string n)
        {
            return n+"done";
        }

        private void AddToManagers(IStockManager sm)
        {
            foreach(StockManager manager in managers)
            {
                manager.Add(sm);
            }
            Console.WriteLine("StockManager added to Managers");
        }

        private void RemoveFromManagers(IStockManager sm)
        {
            foreach (StockManager manager in managers)
            {
                manager.Remove(sm);
            }
            Console.WriteLine("StockManager removed from Managers");
        }
    }
}
