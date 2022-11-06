using Newtonsoft.Json;

namespace NeoLms.Api.DotNet.Models
{
    public class Resource
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("library")]
        public string Library { get; set; }

        [JsonProperty("creator_id")]
        public int CreatorId { get; set; }

        [JsonProperty("created_at")]
        public DateTime CreatedAt { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("lo_age")]
        public int LoAge { get; set; }

        [JsonProperty("hi_age")]
        public int HiAge { get; set; }
    }
}
