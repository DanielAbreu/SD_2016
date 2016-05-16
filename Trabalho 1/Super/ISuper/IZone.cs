using ISuper;
using System;
using System.Collections.Generic;

namespace ISuperInterfaces
{
    public interface IStockManager
    {
        string IsAlive(string i);
        IEnumerable<Item> GetSuperStock();

    }

    public interface IZone
    {
        string isAlive(string n);
        void Register(IStockManager stockManager, string[] families);

        void Unregister(IStockManager stockManager);

        IEnumerable<Item> GetItemStock(string item);
    }

    
    
}
