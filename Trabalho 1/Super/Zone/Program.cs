using System;
using System.Collections.Generic;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Http;
using System.Runtime.Remoting;
using ISuper;
using System.Collections;

namespace Zone
{
    public class Program
    {
        static List<StockManager> managers;
        static Dictionary<string, List<Item>> stockCache;
        static void Main(string[] args)
        {
            managers = null;
            HttpChannel ch = new HttpChannel(1234);
            ChannelServices.RegisterChannel(ch, false);
            RemotingConfiguration.RegisterWellKnownServiceType(
                typeof(StockManager),
                "Stock1.xml",
                WellKnownObjectMode.Singleton
            );
            Console.WriteLine("Waiting Request...");
        }
        static void Register(StockManager sm, IEnumerable<Item> items)
        {
            managers.Add(sm);
            foreach (Item it in items)
            {
                if (stockCache.ContainsKey(it.Name)) {

                    List<Item> li = stockCache[it.Name];
                    li.Add(it);
                    stockCache[it.Name] = li;
                }
                else
                {
                    stockCache.Add(it.Name, new List<Item> { it });
                }
            }
        }
        static void Unregister(StockManager sm)
        {
            managers.Remove(sm);
        }
        public IEnumerable<Item> LoadStock(string name)
        {
            return stockCache[name];
        }
    }
}
