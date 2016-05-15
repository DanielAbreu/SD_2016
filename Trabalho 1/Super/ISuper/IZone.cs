using ISuper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISuperInterfaces
{
    public interface IStockManager
    {
        IZone zone { get; set; }

        IEnumerable<Item> GetStock(string it);
    }

    public interface IZone
    {
        void Register(IStockManager stockManager, IEnumerable<Item> stock);

        void Unregister(IStockManager stockManager);

        IEnumerable<Item> GetItemStock(string item);
    }
}
