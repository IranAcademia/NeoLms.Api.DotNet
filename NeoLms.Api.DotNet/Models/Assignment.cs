using Newtonsoft.Json;

namespace NeoLms.Api.DotNet.Models;

public class Assignment
{
    [JsonProperty("id")]
    public int Id { get; set; }

    [JsonProperty("name")]
    public string Name { get; set; }

    [JsonProperty("type")]
    public string Type { get; set; }

    [JsonProperty("points")]
    public double Points { get; set; }

    [JsonProperty("weight")]
    public object Weight { get; set; }

    [JsonProperty("category")]
    public string Category { get; set; }

    [JsonProperty("grading")]
    public string Grading { get; set; }

    [JsonProperty("gateway")]
    public bool Gateway { get; set; }

    [JsonProperty("lesson")]
    public int Lesson { get; set; }

    [JsonProperty("begin")]
    public DateTime Begin { get; set; }

    [JsonProperty("end")]
    public DateTime End { get; set; }

    [JsonProperty("given")]
    public bool Given { get; set; }

    [JsonProperty("grader_id")]
    public int GraderId { get; set; }

    [JsonProperty("graded_at")]
    public DateTime GradedAt { get; set; }

    [JsonProperty("submitted_at")]
    public DateTime SubmittedAt { get; set; }

    [JsonProperty("percent")]
    public string Percent { get; set; }

    [JsonProperty("grade")]
    public string Grade { get; set; }

    [JsonProperty("score")]
    public string Score { get; set; }

    [JsonProperty("comment")]
    public string Comment { get; set; }
}
