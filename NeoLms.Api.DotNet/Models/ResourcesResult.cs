using Newtonsoft.Json;

namespace NeoLms.Api.DotNet.Models
{
    public class ResourcesResult
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("resources")]
        public List<Resource> Resources { get; set; }
    }
}