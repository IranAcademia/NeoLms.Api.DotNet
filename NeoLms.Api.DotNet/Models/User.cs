using Newtonsoft.Json;

namespace NeoLms.Api.DotNet.Models;

public class User
{
    [JsonProperty("id")]
    public int Id { get; set; }

    [JsonProperty("userid")]
    public string UserId { get; set; }

    [JsonProperty("password")]
    public string Password { get; set; }

    [JsonProperty("joined_at")]
    public DateTime JoinedAt { get; set; }

    [JsonProperty("first_login_at")]
    public DateTime FirstLoginAt { get; set; }

    [JsonProperty("last_login_at")]
    public DateTime LastLoginAt { get; set; }

    [JsonProperty("logins")]
    public int? Logins { get; set; }

    [JsonProperty("first_name")]
    public string FirstName { get; set; }

    [JsonProperty("last_name")]
    public string LastName { get; set; }

    [JsonProperty("email")]
    public string Email { get; set; }

    [JsonProperty("sms_email")]
    public object SmsEmail { get; set; }

    [JsonProperty("phone")]
    public object Phone { get; set; }

    [JsonProperty("teacher")]
    public bool IsTeacher { get; set; }

    [JsonProperty("student")]
    public bool IsStudent { get; set; }

    [JsonProperty("assistant")]
    public bool IsAssistant { get; set; }

    [JsonProperty("administrator")]
    public bool IsAdministrator { get; set; }

    [JsonProperty("monitor")]
    public bool IsMonitor { get; set; }

    [JsonProperty("mentor")]
    public bool IsMentor { get; set; }

    [JsonProperty("student_id")]
    public object StudentId { get; set; }

    [JsonProperty("teacher_id")]
    public object TeacherId { get; set; }

    [JsonProperty("birthdate")]
    public object Birthdate { get; set; }

    [JsonProperty("nick_name")]
    public object NickName { get; set; }

    [JsonProperty("skype")]
    public object Skype { get; set; }

    [JsonProperty("street_1")]
    public object Street1 { get; set; }

    [JsonProperty("street_2")]
    public object Street2 { get; set; }

    [JsonProperty("city")]
    public object City { get; set; }

    [JsonProperty("state")]
    public object State { get; set; }

    [JsonProperty("country")]
    public string Country { get; set; }

    [JsonProperty("zip")]
    public object Zip { get; set; }

    [JsonProperty("archived")]
    public bool Archived { get; set; }

    [JsonProperty("picture")]
    public string Picture { get; set; }

    [JsonProperty("gender")]
    public object Gender { get; set; }

    [JsonProperty("ssn")]
    public object Ssn { get; set; }
}