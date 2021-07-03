using System.Xml.Serialization;

namespace AlgoTectureXMLtoJsonParser.XML
{
    [XmlRoot(ElementName="Attr")]
    public class Attr { 

        [XmlAttribute(AttributeName="Name")] 
        public string Name { get; set; } 

        [XmlAttribute(AttributeName="Type")] 
        public string Type { get; set; } 

        [XmlAttribute(AttributeName="Value")] 
        public string Value { get; set; } 
    }
}