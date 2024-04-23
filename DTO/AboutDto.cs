using Newtonsoft.Json;

namespace Portfolio.DTO
{
    public class AboutDto
    {
        [JsonProperty ("full_name")]
        public string FullName { get; set; } = string.Empty;
        [JsonProperty("title")]
        public string Title { get; set; } = string.Empty;
        [JsonProperty("description")]
        public string Description { get; set; } = string.Empty;
        [JsonProperty("listed_desc")]
        public List<string>ListedDescription { get; set; } = new List<string>();



        //public string ShortDesc1 { get; set; } = string.Empty;
        //[JsonProperty("short_desc2")]
        //public string ShortDesc2 { get; set; } = string.Empty;
        //[JsonProperty("short_desc3")]
        //public string ShortDesc3 { get; set; } = string.Empty;
        //[JsonProperty("short_desc4")]
        //public string ShortDesc4 { get; set; } = string.Empty;
        //[JsonProperty("short_desc5")]
        //public string ShortDesc5 { get; set; } = string.Empty;
        //[JsonProperty("short_desc6")]
        //public string ShortDesc6 { get; set; } = string.Empty;
        [JsonProperty("resume_link")]
        public string ResumeLink { get; set; } = string.Empty;
        [JsonProperty("cover_letter_link")]
        public string CoverLetterLink { get; set; } = string.Empty;
    }
}
