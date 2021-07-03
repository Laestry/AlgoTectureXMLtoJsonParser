using Newtonsoft.Json;

namespace AlgoTectureXMLtoJsonParser.Json
{
    public class Prop
    {
        [JsonProperty("Name")]
        public string Name { get; set; }

        [JsonProperty("Type")]
        public string Type { get; set; }

        [JsonProperty("Value")]
        public string Value { get; set; }

        public Prop(string name, string type, string value)
        {
            Name = name;
            Type = type;
            Value = value;
        }
    }
}