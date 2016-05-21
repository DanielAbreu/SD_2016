using ISuper;
using System;
using System.Collections.Generic;

namespace ISuperInterfaces
{
    public interface IStockManager
    {

        string IsAlive(string i);

        IEnumerable<Item> GetSuperStock();

        void Add(IStockManager sm);

        void Remove(IStockManager sm);

    }

    public interface IZone
    {
        string isAlive(string n);

        void Register(IStockManager stockManager);

        void Unregister(IStockManager stockManager);
    }

    
    
}
