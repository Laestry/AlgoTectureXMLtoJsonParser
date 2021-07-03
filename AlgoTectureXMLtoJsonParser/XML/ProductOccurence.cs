using System.Xml.Serialization;

namespace AlgoTectureXMLtoJsonParser.XML
{
    public class ProductOccurence
    {
        [XmlElement(ElementName="Attributes")] 
        public Attributes Attributes { get; set; } 
        
        // [XmlAttribute(AttributeName="IsPart")] 
        // public bool IsPart { get; set; } 
        //
        // [XmlAttribute(AttributeName="Unit")] 
        // public double Unit { get; set; } 
        //
        // [XmlAttribute(AttributeName="Children")] 
        // public int Children { get; set; } 
        //
        // [XmlAttribute(AttributeName="Behaviour")] 
        // public int Behaviour { get; set; } 

        [XmlAttribute(AttributeName="Name")] 
        public string Name { get; set; } 

        [XmlAttribute(AttributeName="Id")] 
        public int Id { get; set; } 
    }
}