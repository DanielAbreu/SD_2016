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

        IEnumerable<Item> GetLocalStock(string it);
        IEnumerable<Item> GetRemoteStock(string it);
    }

    public interface IZone
    {
        int port { get; set; }

        void Register(IStockManager stockManager, IEnumerable<Item> stock);

        void Unregister(IStockManager stockManager);

        IEnumerable<Item> GetItemStock(string item);
    }
}
