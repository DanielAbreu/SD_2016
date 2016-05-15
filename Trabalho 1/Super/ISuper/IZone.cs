using ISuper;
using System;
using System.Collections.Generic;

namespace ISuperInterfaces
{
    public interface IStockManager
    {

    }

    public interface IZone
    {
        void Register(IStockManager stockManager, Item[] stock);

        void Unregister(IStockManager stockManager);

        IEnumerable<Item> GetItemStock(string item);
    }

    [Serializable]
    public class StockManager : IStockManager
    {
        
    }
}
