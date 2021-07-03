using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using AlgoTectureXMLtoJsonParser.Json;
using Newtonsoft.Json;
using Root = AlgoTectureXMLtoJsonParser.XML.Root;

namespace AlgoTectureXMLtoJsonParser
{
    class Program
    {
        private static readonly string CurrentDirectory = Directory.GetCurrentDirectory();

        static void Main(string[] args)
        {
            SerializeJson(DeserializeXml());
        }
        
        private static Root DeserializeXml()
        {
            Root xmlRoot;
            
            string filePath = Path.Combine(CurrentDirectory, "test.xml");
            
            XmlSerializer serializer = new XmlSerializer(typeof(Root));

            using (StreamReader reader = new StreamReader(filePath))
            {
                xmlRoot = (Root)serializer.Deserialize(reader);
            }

            return xmlRoot;
        }

        private static void SerializeJson(Root xmlRoot)
        {
            int i = 0;
            List<Json.Root> jsonList = new List<Json.Root>();

            foreach (var productOccurence in xmlRoot.ModelFile.ProductOccurence)
            {
                jsonList.Add(new Json.Root(productOccurence.Id.ToString(), productOccurence.Name));

                if (productOccurence.Attributes != null)
                    foreach (var attr in productOccurence.Attributes.Attr)
                    {
                        jsonList[i].Props.Add(new Prop(attr.Name, attr.Type, attr.Value));
                    }

                i++;
            }
            
            var json = JsonConvert.SerializeObject(jsonList, Formatting.Indented);
            
            string filePath = Path.Combine(CurrentDirectory, "result.json");
            
            File.WriteAllText(filePath, json);
        }
    }
}