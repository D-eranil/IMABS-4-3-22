using CMS.DocumentEngine.Types.IMABS;
using IMABS.Helpers;

namespace IMABS.Models.Banners
{
    /// <summary>
    /// Get banner section details
    /// </summary>
    public class BannerSectionViewModel
    {
        public string BannerHeading { get; set; }
        public string BannerBreadcrumbsTitle { get; set; }
        public bool IsActiveBanner { get; set; }
        public string DesktopBannerImage { get; set; }
        public string TabletBannerImage { get; set; }
        public string MobileBannerImage { get; set; }
        public string ButtonLinkName { get; set; }
        public string ButtonRedirectionUrl { get; set; }

        /// <summary>
        /// Based on page type set the local view model
        /// </summary>
        /// <param name="bannerSection"></param>
        /// <returns></returns>
        public static BannerSectionViewModel GetViewModel(BannerSection bannerSection)
        {
            return bannerSection == null ? null : new BannerSectionViewModel
            {
                BannerHeading = bannerSection.Fields.BannerHeading,
                BannerBreadcrumbsTitle = bannerSection.Fields.BannerBreadcrumbsTitle,
                IsActiveBanner = bannerSection.Fields.IsActiveBanner,
                DesktopBannerImage = ImageHelper.GetImage(bannerSection.Fields.DesktopBanner),
                TabletBannerImage = ImageHelper.GetImage(bannerSection.Fields.TabletBanner),
                MobileBannerImage = ImageHelper.GetImage(bannerSection.Fields.MobileBanner),
                ButtonLinkName = bannerSection.Fields.ButtonLinkName,
                ButtonRedirectionUrl = bannerSection.Fields.ButtonRedirectionUrl.ToString()
            };
        }
    }
}
