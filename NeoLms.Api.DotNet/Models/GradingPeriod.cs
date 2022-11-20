using Newtonsoft.Json;

namespace NeoLms.Api.DotNet.Models
{
    public class GradingPeriod
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("percent")]
        public string? Percent { get; set; }

        [JsonProperty("start")]
        public string Start { get; set; }

        [JsonProperty("grade")]
        public string Grade { get; set; }

        [JsonProperty("assignments")]
        public List<Assignment> Assignments { get; set; }
    }
}
