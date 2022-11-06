using Newtonsoft.Json;

namespace NeoLms.Api.DotNet.Models;

public class Student : User
{
    [JsonProperty("enroll_type")]
    public string EnrollType { get; set; }

    [JsonProperty("enrolled_at")]
    public DateTime? EnrolledAt { get; set; }

    [JsonProperty("enrolled_by_id")]
    public int EnrolledById { get; set; }

    [JsonProperty("started_at")]
    public DateTime? StartedAt { get; set; }

    [JsonProperty("last_visited_at")]
    public DateTime? LastVisitedAt { get; set; }

    [JsonProperty("time_spent")]
    public int? TimeSpent { get; set; }

    [JsonProperty("completed_at")]
    public DateTime? CompletedAt { get; set; }

    [JsonProperty("unenrolled")]
    public bool Unenrolled { get; set; }

    [JsonProperty("unenrolled_at")]
    public DateTime? UnenrolledAt { get; set; }

    [JsonProperty("unenrolled_by_id")]
    public object UnenrolledById { get; set; }

    [JsonProperty("deactivated")]
    public bool Deactivated { get; set; }

    [JsonProperty("deactivated_at")]
    public DateTime? DeactivatedAt { get; set; }

    [JsonProperty("reactivated_at")]
    public DateTime? ReactivatedAt { get; set; }
}
