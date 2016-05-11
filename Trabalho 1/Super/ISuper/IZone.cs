﻿using ISuper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IZone
{
    public interface IStockManager
    {
        IEnumerable<Item> GetLocalStock();
        IEnumerable<Item> GetRemoteStock();
    }

    public interface IZone
    {
        void Register(IStockManager sm, IEnumerable<Item> stock);

        void Unregister();
    }
}