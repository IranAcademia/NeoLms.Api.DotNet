using Newtonsoft.Json;

namespace NeoLms.Api.DotNet.Models
{
    public class Lesson
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("start_at")]
        public DateTime? StartAt { get; set; }

        [JsonProperty("end_at")]
        public DateTime? EndAt { get; set; }

        [JsonProperty("all_day")]
        public bool AllDay { get; set; }

        [JsonProperty("picture")]
        public string Picture { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("location")]
        public object Location { get; set; }

        [JsonProperty("sections")]
        public List<ClassSection> Sections { get; set; }
    }
}
