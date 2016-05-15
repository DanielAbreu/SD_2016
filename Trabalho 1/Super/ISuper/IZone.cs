using ISuper;
using System.Collections.Generic;

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
