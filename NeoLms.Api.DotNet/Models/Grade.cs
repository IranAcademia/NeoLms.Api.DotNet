using Newtonsoft.Json;

namespace NeoLms.Api.DotNet.Models;

public class Grade
{
    [JsonProperty("user_id")]
    public int UserId { get; set; }

    [JsonProperty("percent")]
    public string Percent { get; set; }

    [JsonProperty("grade")]
    public string GradeName { get; set; }

    [JsonProperty("grading_periods")]
    public List<GradingPeriod> GradingPeriods { get; set; }
}