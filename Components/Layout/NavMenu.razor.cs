using Portfolio.DTO;

namespace Portfolio.Components.Layout
{
    public partial class NavMenu
    {
        private WelcomeDto welcomeMessage = new();

        protected override void OnInitialized()
        {
            welcomeMessage = _readJson.ReadJsonFile<WelcomeDto>(welcomeMessage, "welcome.json");          
        }
    }
}
