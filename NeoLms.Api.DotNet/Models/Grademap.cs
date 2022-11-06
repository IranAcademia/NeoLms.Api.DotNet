using Newtonsoft.Json;

namespace NeoLms.Api.DotNet.Models
{
    public class Grademap
    {
        [JsonProperty("grade")]
        public string Grade { get; set; }

        [JsonProperty("minimum_percent")]
        public double? MinimumPercent { get; set; }
    }
}