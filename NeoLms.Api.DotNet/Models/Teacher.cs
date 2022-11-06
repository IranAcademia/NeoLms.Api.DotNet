using Newtonsoft.Json;

namespace NeoLms.Api.DotNet.Models;

public class Teacher : User
{
    [JsonProperty("coteacher")]
    public bool Coteacher { get; set; }
}
