using Newtonsoft.Json;

namespace Portfolio.DTO
{
    public class ProjectsDto
    {
        [JsonProperty("projects")]
        public List<ProjectsBreakdown> CreatedProjects = new List<ProjectsBreakdown>();
    }



    /// <summary>
    /// Class for work and education history
    /// </summary>
    public class ProjectsBreakdown
    {
        [JsonProperty("project_name")]
        public string ProjectName { get; set; } = string.Empty;

        [JsonProperty("project_desc")]
        public string ProjectDescription { get; set; } = string.Empty;

        [JsonProperty("project_img")]
        public string ProjectImage { get; set; } = string.Empty;

        [JsonProperty("project_link")]
        public string ProjectLink { get; set; } = string.Empty;
    }
}
