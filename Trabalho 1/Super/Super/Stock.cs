﻿using ISuper;
using System;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Xml.Serialization;

namespace Super
{
    [Serializable]
    public class SuperStock
    {
        public StockLoader sl;
        public string[] Families 
        {   get
            {
                return Stock.Select(s => s.Family).ToArray();
            }
        }
        private Item[] _Stock;
        public Item[] Stock
        {
            get
            {
                if (_Stock == null)
                {
                    _Stock = sl.LoadStock();
                }
                return _Stock;
            }
        }   
    }
    public class StockLoader
    {
        private string stockPath
        {
            get
            {
                if (ConfigurationManager.AppSettings["StockPath"] == null)
                {
                    throw new ArgumentNullException("Key StockPath not present in App.config");
                }
                return ConfigurationManager.AppSettings["StockPath"];
            }
        }
        public Item[] LoadStock()
        {
            Stock stock = null;

            XmlSerializer serializer = new XmlSerializer(typeof(Stock));

            StreamReader reader = new StreamReader(stockPath);
            stock = (Stock)serializer.Deserialize(reader);
            reader.Close();

            return stock.Items;
        }
    }
}
