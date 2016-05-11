using ISuper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Super
{
    public class SuperStock
    {
        private IEnumerable<Item> _Stock;
        public IEnumerable<Item> Stock
        {
            get
            {
                if (_Stock == null)
                {
                    _Stock = LoadStock();
                }
                return _Stock;
            }
        }

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


        private IEnumerable<Item> LoadStock()
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
