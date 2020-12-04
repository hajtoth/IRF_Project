using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace project
{
    [XmlType("book")]
    public class Book
    {
        [XmlAttribute("id")]
        public string bookId { get; set; }
        [XmlElement(ElementName ="author")]
        public string author { get; set; }

        [XmlElement(ElementName = "title")]
        public string title { get; set; }
        [XmlElement(ElementName = "genre")]
        public string genre { get; set; }
        [XmlElement(ElementName = "price")]
        public double price { get; set; }
        [XmlElement(ElementName = "publish_date")]
        public DateTime publish_date { get; set; }
        [XmlElement(ElementName = "description")]
        public string description { get; set; }

    }
}
