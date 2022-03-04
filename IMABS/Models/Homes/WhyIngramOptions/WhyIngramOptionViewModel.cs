using CMS.DocumentEngine.Types.IMABS;
using IMABS.Helpers;
using IMABS.Models.Homes.ActionLinks;
using IMABS.Repositories;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace IMABS.Models.Homes.WhyIngramOptions
{
    /// <summary>
    /// Get details for why ingram section
    /// </summary>
    public class WhyIngramOptionViewModel
    {
        public string ImageHeading { get; set; }
        public string NavigationLink { get; set; }
        public string NavigationLinkId { get; set; }
        public string BackgroundImage { get; set; }
        public List<ActionLinkViewModel> ActionLinks { get; set; }

        /// <summary>
        /// Based on whyIngramOption page type getting the local view model content
        /// </summary>
        /// <param name="whyIngramOption"></param>
        /// <returns></returns>
        public static WhyIngramOptionViewModel GetViewModel(WhyIngramOption whyIngramOption, HomeRepository mhomeRepository, bool DisableCache, CancellationToken cancellationToken)
        {
            var actionLinks = new List<ActionLink>(mhomeRepository.GetActionLinks(DisableCache, whyIngramOption.NodeAliasPath, cancellationToken).Result);
            return whyIngramOption == null ? null : new WhyIngramOptionViewModel
            {
                ImageHeading = whyIngramOption.Fields.ImageHeading,
                NavigationLink = whyIngramOption.Fields.NavigationLink,
                NavigationLinkId = whyIngramOption.Fields.NavigationLinkId,
                BackgroundImage = ImageHelper.GetImage(whyIngramOption.Fields.BackgroundImage),
                //Get action links for the whyingram section which is placed under the image on right side
                ActionLinks = actionLinks.Select(ActionLinkViewModel.GetViewModel).OrderByDescending(x => x.NodeOrder).ToList()
            };
        }
    }
}
