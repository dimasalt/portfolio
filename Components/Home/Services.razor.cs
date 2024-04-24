using Portfolio.DTO;

namespace Portfolio.Components.Home
{
    public partial class Services
    {
        private ServicesDto servicesMessage = new();

        protected override void OnInitialized()
        {
            servicesMessage = _readJson.ReadJsonFile<ServicesDto>(servicesMessage, "services.json");
        }
    }
}

