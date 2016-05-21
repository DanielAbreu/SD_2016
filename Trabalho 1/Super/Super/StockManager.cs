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
        public IStockManager[] managers;
        public SuperStock stock;
        public StockManager(SuperStock st)
        {
            this.stock = st;
        }

        public List<Item> GetStockFromFamilies(string family)
        {
            return managers.SelectMany(m => m.GetSuperStock()).Where(s => s.Family.Contains(family)).ToList();
        }

        public IEnumerable<Item> GetSuperStock()
        {
            return stock.Stock;
        }

        public string IsAlive(string i)
        {
            return i + "done";
        }

        public void Add(IStockManager sm)
        {
            if (!managers.Contains(sm))
            {
                IStockManager[] prevManagers = managers;
                managers = new IStockManager[prevManagers.Length + 1];

                for (int i = 0; i < managers.Length; ++i)
                {
                    if (i < prevManagers.Length)
                    {
                        managers[i] = prevManagers[i];
                    }
                    else
                    {
                        managers[i] = sm;
                    }
                    
                }
            }
        }

        public void Remove(IStockManager sm)
        {
            if (managers.Contains(sm))
            {
                IStockManager[] prevManagers = managers;
                managers = new IStockManager[prevManagers.Length - 1];

                int j = 0;
                for (int i = 0; i < prevManagers.Length; ++i)
                {
                    if (prevManagers[i] == sm)
                    {
                        continue;
                    }
                    else
                    {
                        managers[j++] = prevManagers[i];
                    }
                }
            }
        }
    }
}
