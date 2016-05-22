using ISuper;
using System;
using System.Collections.Generic;

namespace ISuperInterfaces
{
    public interface IStockManager
    {
        IEnumerable<Item> GetSuperStock();

        void Add(IStockManager sm);

        void Remove(IStockManager sm);

    }

    public interface IZone
    {
        void Register(IStockManager stockManager);

        void Unregister(IStockManager stockManager);
    }

    
    
}
