using Portfolio.DTO;

namespace Portfolio.Components.Home
{
    public partial class Projects
    {
        private ProjectsDto projectsMessage = new();

        protected override void OnInitialized()
        {
            projectsMessage = _readJson.ReadJsonFile<ProjectsDto>(projectsMessage, "projects.json");
        }
    }
}
