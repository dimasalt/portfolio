using Newtonsoft.Json;

namespace Portfolio.DTO;

public class WelcomeDto
{
    [JsonProperty ("welcome_message")]
    public string WelcomeMessage { get; set; } = string.Empty;
    [JsonProperty ("first_name")]
    public string FirtName { get; set; } = string.Empty;
    [JsonProperty ("last_name")]
    public string LastName { get; set; } = string.Empty;
    [JsonProperty ("title")]
    public string Title { get; set; } = string.Empty;
}
