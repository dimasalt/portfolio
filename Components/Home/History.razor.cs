using Portfolio.DTO;

namespace Portfolio.Components.Home
{
    public partial class History
    {
        private HistoryDto historyMessage = new();

        protected override void OnInitialized()
        {
            historyMessage = _readJson.ReadJsonFile<HistoryDto>(historyMessage, "history.json");
        }
    }
}
