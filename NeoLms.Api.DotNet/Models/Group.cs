using Newtonsoft.Json;

namespace IranAcademiaChatBotServer.Agents.Academia.NeoLms.Models;

public class Group
{
    [JsonProperty("id")]
    public int Id { get; set; }

    [JsonProperty("name")]
    public string Name { get; set; }

    [JsonProperty("description")]
    public string Description { get; set; }

    [JsonProperty("access_code")]
    public string AccessCode { get; set; }

    [JsonProperty("type")]
    public string Type { get; set; }

    [JsonProperty("scope")]
    public string Scope { get; set; }

    [JsonProperty("picture")]
    public string Picture { get; set; }
}