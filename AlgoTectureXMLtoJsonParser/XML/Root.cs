using System.Xml.Serialization;

namespace AlgoTectureXMLtoJsonParser.XML
{
    [XmlRoot(ElementName="Root")]
    public class Root { 

        [XmlElement(ElementName="ModelFile")] 
        public ModelFile ModelFile { get; set; } 
    }
}