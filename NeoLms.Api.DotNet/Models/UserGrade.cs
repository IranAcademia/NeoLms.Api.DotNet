using Newtonsoft.Json;

namespace NeoLms.Api.DotNet.Models;

public class UserGrade
{
    [JsonProperty("class_id")]
    public int ClassId { get; set; }

    [JsonProperty("grades")]
    public Grade Grade { get; set; }
}