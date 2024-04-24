using Newtonsoft.Json;

namespace Portfolio.DTO
{
    public class HistoryDto 
    {
        [JsonProperty("education")]
        public List<HistoryBreakdown> EducationHistory { get; set; } = new List<HistoryBreakdown>();

        [JsonProperty("experience")]
        public List<HistoryBreakdown> ExperienceHistory { get; set; } = new List<HistoryBreakdown>();


    }


    /// <summary>
    /// Class for work and education history
    /// </summary>
    public class HistoryBreakdown
    {
        [JsonProperty("year")]
        public string Year { get; set; } = string.Empty;

        [JsonProperty("place_name")]
        public string PlaceName { get; set; } = string.Empty;

        [JsonProperty("title")]
        public string Title { get; set; } = string.Empty;

        [JsonProperty("description")]
        public string Description { get; set; } = string.Empty;
    }
}
