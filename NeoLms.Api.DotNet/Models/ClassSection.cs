using Newtonsoft.Json;

namespace NeoLms.Api.DotNet.Models
{
    public class ClassSection
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("assignment_id")]
        public int? AssignmentId { get; set; }
    }
}
