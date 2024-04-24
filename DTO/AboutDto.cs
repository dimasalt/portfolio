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

        [JsonProperty("resume_link")]
        public string ResumeLink { get; set; } = string.Empty;
        
        [JsonProperty("cover_letter_link")]
        public string CoverLetterLink { get; set; } = string.Empty;
    }
}
