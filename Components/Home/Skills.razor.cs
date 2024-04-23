using Portfolio.DTO;

namespace Portfolio.Components.Home;

public partial class Skills
{
    private AboutDto aboutMessage = new();

    protected override void OnInitialized()
    {
        aboutMessage = _readJson.ReadJsonFile<AboutDto>(aboutMessage, "about.json");
    }
}
