using Newtonsoft.Json;

namespace Portfolio.DTO
{
    public class SkillsDto 
    {
        [JsonProperty("coding_skills")]
        public List<SkillsBreakdown> CodingSkills { get; set; } = new List<SkillsBreakdown>();

        [JsonProperty("design_skills")]
        public List<SkillsBreakdown> DesignSkills { get; set; } = new List<SkillsBreakdown>();


    }


    /// <summary>
    /// Class for coding and design skills
    /// </summary>
    public class SkillsBreakdown
    {
        [JsonProperty("skill")]
        public string Skill { get; set; } = string.Empty;

        [JsonProperty("level")]
        public int Level { get; set; } = 0;
    }
}
