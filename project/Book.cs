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
        public string BookId { get; set; }
        [XmlElement(ElementName ="author")]
        public string Author { get; set; }

        [XmlElement(ElementName = "title")]
        public string Title { get; set; }
        [XmlElement(ElementName = "genre")]
        public string Genre { get; set; }
        [XmlElement(ElementName = "price")]
        public double Price { get; set; }
        [XmlElement(ElementName = "publish_date")]
        public DateTime PublishDate { get; set; }
        [XmlElement(ElementName = "description")]
        public string Description { get; set; }

    }
}
