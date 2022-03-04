using CMS.DocumentEngine.Types.IMABS;

namespace IMABS.Models.Tool
{
    public class ToolsViewModel : CommonSettingsViewModel
    {
        public string ToolsTitle { get; set; }
        public static ToolsViewModel GetViewModel(Tools tools)
        {
            var item = tools == null ? null : new ToolsViewModel()
            {
                ToolsTitle = tools.Fields.Title
            };

            return item;
        }
    }
}
