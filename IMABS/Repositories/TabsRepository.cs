using CMS.DocumentEngine;
using CMS.DocumentEngine.Types.IMABS;
using CMS.SiteProvider;
using System.Collections.Generic;
using System.Linq;

namespace IMABS.Repositories
{
    public class TabsRepository
    {

        public List<Tabs> GetTabs()
        {
            return TabsProvider.GetTabs()
                .Published(true)
                .OnSite(SiteContext.CurrentSiteName)
                .CombineWithDefaultCulture()
                .OrderBy("NodeOrder")
                .Where(x => x.IsActive)
                .ToList();
        }

        public List<AccordionItem> GetItems(string nodeAliasPath)
        {
            return AccordionItemProvider.GetAccordionItems()
                .Path(nodeAliasPath, PathTypeEnum.Children)
                .Published(true)
                .OnSite(SiteContext.CurrentSiteName)
                .CombineWithDefaultCulture()
                .ToList();
        }
    }
}
