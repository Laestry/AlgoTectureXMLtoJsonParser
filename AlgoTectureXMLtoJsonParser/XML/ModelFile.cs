using System.Collections.Generic;
using System.Xml.Serialization;
using AlgoTectureXMLtoJsonParser.XML;

namespace AlgoTectureXMLtoJsonParser.XML
{
    [XmlRoot(ElementName="ModelFile")]
    public class ModelFile { 

        [XmlElement(ElementName="ProductOccurence")] 
        public List<ProductOccurence> ProductOccurence { get; set; } 
    }
}