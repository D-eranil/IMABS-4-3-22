using IMABS.Models.Banners;
using IMABS.Models.Homes.HomePopups;
using IMABS.Models.Homes.WhyIngramOptions;
using System.Collections.Generic;

namespace IMABS.Models.Homes
{
    /// <summary>
    /// Getting the home page related details
    /// </summary>
    public class HomeViewModel: CommonSettingsViewModel
    {
        public List<BannerSectionViewModel> bannerSections { get; set; }
        public List<WhyIngramOptionViewModel> whyIngramOptions { get; set; }
        public HomePopupViewModel homePopupDetails { get; set; }
    }
}
