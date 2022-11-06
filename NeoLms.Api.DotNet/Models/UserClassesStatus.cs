using Newtonsoft.Json;

namespace NeoLms.Api.DotNet.Models;

public class UserClassesStatus
{
    [JsonProperty("enrolled")]
    public int[] Enrolled { get; set; }

    [JsonProperty("completed")]
    public int[] Completed { get; set; }

    [JsonProperty("deactivated")]
    public int[] Deactivated { get; set; }
}