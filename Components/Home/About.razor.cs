using Portfolio.DTO;
namespace Portfolio.Components.Home;

public partial class About
{
    private AboutDto aboutMessage = new();

    protected override void OnInitialized()
    {
        aboutMessage = _readJson.ReadJsonFile<AboutDto>(aboutMessage, "about.json");
    }
}
