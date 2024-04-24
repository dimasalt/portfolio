using Newtonsoft.Json;

namespace Portfolio.DTO
{
    public class ServicesDto
    {
        [JsonProperty("services")]
        public List<ServicesBreakdown> ProvidedServices = new List<ServicesBreakdown>();
    }



    /// <summary>
    /// Class for work and education history
    /// </summary>
    public class ServicesBreakdown
    {
        [JsonProperty("service_name")]
        public string ServiceName { get; set; } = string.Empty;

        [JsonProperty("description")]
        public string Description { get; set; } = string.Empty;

        [JsonProperty("icon")]
        public string Icon { get; set; } = string.Empty;       
    }
}
