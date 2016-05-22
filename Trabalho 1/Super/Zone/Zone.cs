using ISuperInterfaces;
using Super;
using System;
using System.Collections.Generic;
using System.Configuration;

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
            nextZone = (IZone)Activator.GetObject(typeof(IZone), "http://localhost:" + nextZonePort + "/zone.soap");
        }

        public void Register(IStockManager stockManager)
        {
            Console.WriteLine("Register entered");
            if (managers == null)
            {
                managers = new List<IStockManager>();
            }

            if (managers.Contains(stockManager))
            {
                Console.WriteLine("StockManager already registered in this zone");
                return;
            }
            managers.Add(stockManager);
            AddToManagers(stockManager);
            nextZone.Register(stockManager);
            Console.WriteLine("Successfully Registed the StockManager");
        }

        public void Unregister(IStockManager stockManager)
        {
            Console.WriteLine("Unregister entered");
            if (!managers.Contains(stockManager))
            {
                Console.WriteLine("Stockmanager is not registered in this area");
                return;
            }

            managers.Remove(stockManager);
            RemoveFromManagers(stockManager);
            nextZone.Unregister(stockManager);
            Console.WriteLine("Successfully Unregisted the StockManager");
        }

        private void AddToManagers(IStockManager sm)
        {
            foreach(StockManager manager in managers)
            {
                manager.Add(sm);
                sm.Add(manager);
            }
            Console.WriteLine("StockManager added to Managers");
        }

        private void RemoveFromManagers(IStockManager sm)
        {
            foreach (StockManager manager in managers)
            {
                manager.Remove(sm);
                sm.Remove(manager);
            }
            Console.WriteLine("StockManager removed from Managers");
        }
    }
}
