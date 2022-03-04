using CMS.DocumentEngine.Types.IMABS;
using CMS.SiteProvider;
using System;
using System.Collections.Generic;
using System.Linq;

namespace IMABS.Repositories
{
    public class LandingPageRepository
    {
        private readonly string mCultureName = "en-US";
        private readonly bool mLatestVersionEnabled = true;

        /// <summary>
        /// Returns an object representing the about page.
        /// </summary>
        public LandingPage GetLandingPage()
        {
            return LandingPageProvider.GetLandingPages()
                .LatestVersion(mLatestVersionEnabled)
                .Published(!mLatestVersionEnabled)
                .OnSite(SiteContext.CurrentSiteName)
                .Culture(mCultureName)
                .CombineWithDefaultCulture()
                .TopN(1);
        }

        public LandingPage GetLandingPage(string NodeAliasPath)
        {
            return LandingPageProvider.GetLandingPages()
                 .LatestVersion(mLatestVersionEnabled)
                 .Published(!mLatestVersionEnabled)
                 .Path(NodeAliasPath)
                 .OnSite(SiteContext.CurrentSiteName)
                 .Culture(mCultureName)
                 .CombineWithDefaultCulture()
                 .TopN(1);
        }

        public List<Services> GetServices(Guid NodeGuid)
        {
            return ServicesProvider.GetServices()
               .LatestVersion(mLatestVersionEnabled)
               .Published(!mLatestVersionEnabled)
               .OnSite(SiteContext.CurrentSiteName)
               .Culture(mCultureName)
               .CombineWithDefaultCulture()
               .OrderBy("NodeOrder")
               .Skip(2)
               .Where(x => x.Parent.NodeGUID == NodeGuid)
               .ToList();
        }

        public List<Services> GetTop2Services(Guid NodeGuid)
        {
            return ServicesProvider.GetServices()
             .LatestVersion(mLatestVersionEnabled)
             .Published(!mLatestVersionEnabled)
             .OnSite(SiteContext.CurrentSiteName)
             .Culture(mCultureName)
             .CombineWithDefaultCulture()
             .OrderBy("NodeOrder")
             .TopN(2)
             .Where(x => x.Parent.NodeGUID == NodeGuid)
             .ToList();
        }

    }
}
