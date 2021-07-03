using System.Collections.Generic;
using System.Xml.Serialization;

namespace AlgoTectureXMLtoJsonParser.XML
{
    [XmlRoot(ElementName="Attributes")]
    public class Attributes { 

        [XmlElement(ElementName="Attr")] 
        public List<Attr> Attr { get; set; } 
    }
}