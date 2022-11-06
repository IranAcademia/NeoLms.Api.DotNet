using Newtonsoft.Json;

namespace IranAcademiaChatBotServer.Agents.Academia.NeoLms.Models;

public class AuthenticationResponse
{
    [JsonProperty("authenticated")]
    public bool IsAuthenticated { get; set; }
}
