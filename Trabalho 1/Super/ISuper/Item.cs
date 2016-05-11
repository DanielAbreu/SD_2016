using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ISuper
{
    [Serializable()]
    public class Item
    {
        [XmlElement()]
        public string Name {get; set;}
        [XmlElement()]
        public int Qtd { get; set; }
    }

    [Serializable()]
    [XmlRoot("Stock")]
    public class Stock
    {
        [XmlElement("Item")]
        public List<Item> Items { get; set; }
    }
}
