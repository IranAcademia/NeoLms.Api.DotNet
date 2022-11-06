using Newtonsoft.Json;

namespace NeoLms.Api.DotNet.Models
{
    public class GradingPeriod
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("percent")]
        public double? Percent { get; set; }

        [JsonProperty("start")]
        public string Start { get; set; }
    }
}
