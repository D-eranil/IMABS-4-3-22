using CMS.DocumentEngine.Types.IMABS;
using IMABS.Helpers;

namespace IMABS.Models.Homes.HomePopups
{
    /// <summary>
    /// Home page popup local model
    /// </summary>
    public class HomePopupViewModel
    {
        public string Name { get; set; }
        public string Heading { get; set; }
        public string Image { get; set; }
        public string SiteLink { get; set; }
        public string SiteLinkText { get; set; }
        public string FindoutMoreLink { get; set; }
        public string FindoutMoreLinkText { get; set; }
        public string LayoutHtml { get; set; }

        /// <summary>
        /// Get the home page popup details from page type
        /// </summary>
        /// <param name="homePopup"></param>
        /// <returns></returns>
        public static HomePopupViewModel GetViewModel(HomePopup homePopup)
        {
            var model = homePopup == null ? new HomePopupViewModel() : new HomePopupViewModel
            {
                Name = homePopup.Fields.Name,
                Heading = homePopup.Fields.Heading,
                Image = ImageHelper.GetImage(homePopup.Fields.Image),
                SiteLink = homePopup.Fields.SiteLink,
                SiteLinkText = homePopup.Fields.SiteLinkText,
                FindoutMoreLink = homePopup.Fields.FindoutMoreLink,
                FindoutMoreLinkText = homePopup.Fields.FindoutMoreLinkText,
                LayoutHtml = homePopup.Fields.LayoutHtml
            };

            return model;
        }
    }
}
