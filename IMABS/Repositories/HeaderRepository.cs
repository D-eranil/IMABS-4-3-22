using CMS.DocumentEngine;
using CMS.DocumentEngine.Types.IMABS;
using CMS.SiteProvider;
using System.Collections.Generic;
using System.Linq;

namespace IMABS.Repositories
{
    public class HeaderRepository
    {
        private readonly bool mLatestVersionEnabled;

        public HeaderRepository()
        {
            mLatestVersionEnabled = true;
        }


        /// <summary>
        /// Returns an enumerable collection of Main Menu ordered by a position in the content tree.
        /// </summary>
        public List<LandingPage> GetMainNavMenus()
        {
            return LandingPageProvider.GetLandingPages()
                .LatestVersion(mLatestVersionEnabled)
                .Published(!mLatestVersionEnabled)
                .OnSite(SiteContext.CurrentSiteName)
                .CombineWithDefaultCulture()
                .OrderBy("NodeOrder")
                .Where(x => x.AllowToViewInHeader)
                .ToList();
        }


        /// <summary>
        /// Returns an enumerable collection of Main Menu ordered by a position in the content tree.
        /// </summary>
        public List<LandingPage> GetFooterMainNavMenus()
        {
            return LandingPageProvider.GetLandingPages()
                .LatestVersion(mLatestVersionEnabled)
                .Published(!mLatestVersionEnabled)
                .OnSite(SiteContext.CurrentSiteName)
                .CombineWithDefaultCulture()
                .OrderBy("NodeOrder")
                .Where(x => x.AllowToViewInFooter)
                .ToList();
        }

        /// <summary>
        /// Returns an enumerable collection of Main Menu ordered by a position in the content tree.
        /// </summary>
        public List<MainNavigation> GetMainMenus()
        {
            return MainNavigationProvider.GetMainNavigations()
                .LatestVersion(mLatestVersionEnabled)
                .Published(!mLatestVersionEnabled)
                .OnSite(SiteContext.CurrentSiteName)
                .CombineWithDefaultCulture()
                .OrderBy("NodeOrder")
                .ToList();
        }

        /// <summary>
        /// Returns an enumerable collection of Sub Menu ordered by a position in the content tree.
        /// </summary>
        public List<SubNavigation> GetSubMenus(string nodeGUID = null)
        {
            if (nodeGUID == null)
            {
                return SubNavigationProvider.GetSubNavigations()
                        .LatestVersion(mLatestVersionEnabled)
                        .Published(!mLatestVersionEnabled)
                        .OnSite(SiteContext.CurrentSiteName)
                        .CombineWithDefaultCulture()
                        .OrderBy("NodeOrder")
                        .ToList();
            }
            else
            {
                return SubNavigationProvider.GetSubNavigations()
                        .LatestVersion(mLatestVersionEnabled)
                        .Published(!mLatestVersionEnabled)
                        .OnSite(SiteContext.CurrentSiteName)
                        .CombineWithDefaultCulture()
                        .OrderBy("NodeOrder")
                        .Where(x => x.Parent.NodeGUID.ToString() == nodeGUID)
                        .ToList();
            }
        }

        /// <summary>
        /// Returns an enumerable collection of Sub Footer Menu ordered by a position in the content tree.
        /// </summary>
        public List<SubNavigation> GetFooterSubMenus(string nodeGUID = null)
        {
            if (nodeGUID == null)
            {
                return SubNavigationProvider.GetSubNavigations()
                        .LatestVersion(mLatestVersionEnabled)
                        .Published(!mLatestVersionEnabled)
                        .OnSite(SiteContext.CurrentSiteName)
                        .CombineWithDefaultCulture()
                        .OrderBy("NodeOrder")
                        .ToList();
            }
            else
            {
                return SubNavigationProvider.GetSubNavigations()
                        .LatestVersion(mLatestVersionEnabled)
                        .Published(!mLatestVersionEnabled)
                        .OnSite(SiteContext.CurrentSiteName)
                        .CombineWithDefaultCulture()
                        .OrderBy("NodeOrder")
                        .Where(x => x.Parent.NodeGUID.ToString() == nodeGUID)
                        .ToList();
            }
        }

        /// <summary>
        /// Returns an enumerable collection of Top Menu ordered by a position in the content tree.
        /// </summary>
        public List<TopNavigation> GetTopManus()
        {
            return TopNavigationProvider.GetTopNavigations()
                .LatestVersion(mLatestVersionEnabled)
                .Published(!mLatestVersionEnabled)
                .OnSite(SiteContext.CurrentSiteName)
                .CombineWithDefaultCulture()
                .OrderBy("NodeOrder")
                .ToList();
        }

        /// <summary>
        /// Returns an enumerable collection of Bottom Menu ordered by a position in the content tree.
        /// </summary>
        public List<BottomNavigation> GetBottomManus()
        {
            return BottomNavigationProvider.GetBottomNavigations()
                .LatestVersion(mLatestVersionEnabled)
                .Published(!mLatestVersionEnabled)
                .OnSite(SiteContext.CurrentSiteName)
                .CombineWithDefaultCulture()
                .OrderBy("NodeOrder")
                .ToList();
        }

        /// <summary>
        /// Returns an object representing the home page.
        /// </summary>
        public Header GetHeaderPage()
        {
            return HeaderProvider.GetHeaders()
                .LatestVersion(mLatestVersionEnabled)
                .Published(!mLatestVersionEnabled)
                .OnSite(SiteContext.CurrentSiteName)
                .CombineWithDefaultCulture()
                .TopN(1);
        }

        public List<TreeNode> GetSubMenuList(string nodeGUID = null)
        {
            List<TreeNode> lst = DocumentHelper.GetDocuments()
                .LatestVersion(mLatestVersionEnabled)
                .Published(mLatestVersionEnabled)
                .CombineWithDefaultCulture()
                .OrderBy("NodeOrder")
                .Where(x => x.Parent != null && x.Parent.NodeGUID.ToString() == nodeGUID)
                .ToList();

            return lst;
        }
    }
}
