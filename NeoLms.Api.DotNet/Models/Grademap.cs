using Newtonsoft.Json;

namespace NeoLms.Api.DotNet.Models
{
    public class GradeMap
    {
        [JsonProperty("grade")]
        public string Grade { get; set; }

        [JsonProperty("minimum_percent")]
        public string? MinimumPercent { get; set; }
    }
}