using CMS.DocumentEngine;
using CMS.DocumentEngine.Types.IMABS;
using CMS.SiteProvider;
using System.Collections.Generic;
using System.Linq;

namespace IMABS.Repositories
{
    public class ServicePanelRepository
    {
        private readonly string mCultureName;
        private readonly bool mLatestVersionEnabled;


        public List<ServicePanel> GetChildPagesByAlias(string NodeAliasPath)
        {
            var data = ServicePanelProvider
                       .GetServicePanels()
                       .LatestVersion(mLatestVersionEnabled)
                       .Published(mLatestVersionEnabled)
                       .Path(NodeAliasPath, PathTypeEnum.Children)
                       .OnSite(SiteContext.CurrentSiteName)
                       .Culture(mCultureName)
                       .CombineWithDefaultCulture()
                       .OrderBy("NodeOrder")
                       .ToList();
            return data;
        }
    }
}
