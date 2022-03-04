using IMABS.Models.Service;
using System.Collections.Generic;

namespace IMABS.Models.LandingPages
{
    public class LandingPageViewModel : CommonSettingsViewModel
    {
        public List<ServiceViewModel> services { get; set; }
        public List<ServiceViewModel> top2Services { get; set; }
    }
}
