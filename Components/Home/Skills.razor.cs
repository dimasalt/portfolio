using Portfolio.DTO;

namespace Portfolio.Components.Home
{
    public partial class Skills
    {
        private SkillsDto skillsMessage = new();

        protected override void OnInitialized()
        {
            skillsMessage = _readJson.ReadJsonFile<SkillsDto>(skillsMessage, "skills.json");
        }
    }
}
