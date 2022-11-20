using Newtonsoft.Json;

namespace NeoLms.Api.DotNet.Models
{
    public class EducationClass
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("access_code")]
        public string AccessCode { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("syllabus")]
        public string Syllabus { get; set; }

        [JsonProperty("style")]
        public string Style { get; set; }

        [JsonProperty("course_code")]
        public object CourseCode { get; set; }

        [JsonProperty("section_code")]
        public string SectionCode { get; set; }

        [JsonProperty("credits")]
        public double? Credits { get; set; }

        [JsonProperty("weighting_style")]
        public string WeightingStyle { get; set; }

        [JsonProperty("weight_using_categories")]
        public bool WeightUsingCategories { get; set; }

        [JsonProperty("display_in_catalog")]
        public bool DisplayInCatalog { get; set; }

        [JsonProperty("catalog_category")]
        public string CatalogCategory { get; set; }

        [JsonProperty("grademap")]
        public List<GradeMap> Grademap { get; set; }

        [JsonProperty("grading_periods")]
        public List<GradingPeriod> GradingPeriods { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("time_zone")]
        public string TimeZone { get; set; }

        [JsonProperty("template")]
        public bool Template { get; set; }

        [JsonProperty("parent")]
        public object Parent { get; set; }

        [JsonProperty("organization")]
        public object Organization { get; set; }

        [JsonProperty("organization_id")]
        public object OrganizationId { get; set; }

        [JsonProperty("archived")]
        public bool Archived { get; set; }

        [JsonProperty("picture")]
        public string Picture { get; set; }

        [JsonProperty("start_at")]
        public DateTime StartAt { get; set; }

        [JsonProperty("finish_at")]
        public DateTime FinishAt { get; set; }

        [JsonProperty("categories")]
        public List<Category> Categories { get; set; }

        [JsonProperty("semester")]
        public string Semester { get; set; }

        [JsonProperty("lo_age")]
        public string LoAge { get; set; }

        [JsonProperty("hi_age")]
        public string HiAge { get; set; }

        [JsonProperty("subject")]
        public string Subject { get; set; }

        [JsonProperty("start")]
        public DateTime Start { get; set; }

        [JsonProperty("finish")]
        public DateTime Finish { get; set; }
    }
}