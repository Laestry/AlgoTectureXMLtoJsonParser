using System.Collections.Generic;
using Newtonsoft.Json;

namespace AlgoTectureXMLtoJsonParser.Json
{
    public class Root
    {
        [JsonProperty("Id")]
        public string Id { get; set; }

        [JsonProperty("Name")]
        public string Name { get; set; }

        [JsonProperty("Props")]
        public List<Prop> Props { get; set; }

        public Root(string id, string name)
        {
            Id = id;
            Name = name;
            Props = new List<Prop>();
        }
    }
}