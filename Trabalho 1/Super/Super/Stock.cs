using ISuper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Xml.Serialization;

namespace Super
{
    [Serializable]
    public class SuperStock
    {
        public StockLoader sl;
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

        

        // UMA CLASSE SERIALIZABLE NÃO PODE TER MÉTODOS.
        // AFETAR OS CAMPOS DE STOCK DE OUTRA MANEIRA

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
}
