using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace ISuper
{
    [Serializable]
    public class Item
    {
       [XmlElement()]
        public int SuperID { get; set; }
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
        public Item[] Items { get; set; }
    }
}
