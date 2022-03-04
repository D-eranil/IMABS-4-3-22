using CMS.DocumentEngine;
using CMS.DocumentEngine.Types.IMABS;
using CMS.SiteProvider;
using Kentico.Content.Web.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace IMABS.Repositories
{
    public class HomeRepository
    {
        private readonly IPageRetriever pageRetriever;

        /// <summary>
        /// Initializes a new instance of the <see cref="HomeRepository"/> class that returns home page sections. 
        /// </summary>
        /// <param name="pageRetriever">Retriever for pages based on given parameters.</param>
        public HomeRepository(IPageRetriever pageRetriever)
        {
            this.pageRetriever = pageRetriever;
        }

        public Task<IEnumerable<BannerSection>> GetBanners(string NodeAliasPath, bool DisableCache, CancellationToken cancellationToken)
        {
            if (DisableCache)
            {
                return pageRetriever.RetrieveAsync<BannerSection>(
                    query => query
                        .Path(NodeAliasPath, PathTypeEnum.Children)
                        .Published(true)
                        .OnSite(SiteContext.CurrentSiteName)
                        .CombineWithDefaultCulture()
                        .OrderBy("NodeOrder")
                        .TopN(3)
                        .Where(x => x.IsActiveBanner)
                        .ToList());
            }
            else
            {
                return pageRetriever.RetrieveAsync<BannerSection>(
                    query => query
                        .Path(NodeAliasPath, PathTypeEnum.Children)
                        .Published(true)
                        .OnSite(SiteContext.CurrentSiteName)
                        .CombineWithDefaultCulture()
                        .OrderBy("NodeOrder")
                        .TopN(3)
                        .Where(x => x.IsActiveBanner)
                        .ToList(),
                    cache => cache
                        .Key($"{nameof(HomeRepository)}|{nameof(GetBanners)}|{NodeAliasPath}")
                        // Include path dependency to flush cache when a new child page is created or page order is changed.
                        .Dependencies((_, builder) => builder.PagePath(NodeAliasPath, PathTypeEnum.Children).PageOrder()),
                    cancellationToken);
            }
        }

        /// <summary>
        /// Returns an enumerable collection of Why Ingram Option sections ordered by a position in the content tree.
        /// </summary>
        public Task<IEnumerable<WhyIngramOption>> GetWhyIngramOptions(string NodeAliasPath, bool DisableCache, CancellationToken cancellationToken)
        {
            if (DisableCache)
            {

                return pageRetriever.RetrieveAsync<WhyIngramOption>(
                    query => query
                        .Path(NodeAliasPath, PathTypeEnum.Children)
                .Published(true)
                .OnSite(SiteContext.CurrentSiteName)
                .CombineWithDefaultCulture()
                .OrderBy("NodeOrder")
                .ToList());
            }
            else
            {

                return pageRetriever.RetrieveAsync<WhyIngramOption>(
                    query => query
                    .Path(NodeAliasPath, PathTypeEnum.Children)
                    .Published(true)
                    .OnSite(SiteContext.CurrentSiteName)
                    .CombineWithDefaultCulture()
                    .OrderBy("NodeOrder")
                    .ToList(),
                    cache => cache
                        .Key($"{nameof(HomeRepository)}|{nameof(GetWhyIngramOptions)}|{NodeAliasPath}")
                        // Include path dependency to flush cache when a new child page is created or page order is changed.
                        .Dependencies((_, builder) => builder.PagePath(NodeAliasPath, PathTypeEnum.Children).PageOrder()),
                    cancellationToken);
            }
        }

        /// <summary>
        /// Returns an enumerable collection of ActionLink under why ingram sections ordered by a position in the content tree.
        /// </summary>
        public Task<IEnumerable<ActionLink>> GetActionLinks(bool DisableCache, string NodeAliasPath, CancellationToken cancellationToken)
        {
            if (DisableCache)
            {
                return pageRetriever.RetrieveAsync<ActionLink>(
                 query => query
                    .Path(NodeAliasPath, PathTypeEnum.Children)
                    .Published(true)
                    .OnSite(SiteContext.CurrentSiteName)
                    .CombineWithDefaultCulture()
                    .OrderBy("NodeOrder")
                    .ToList());
            }
            else
            {
                return pageRetriever.RetrieveAsync<ActionLink>(
                 query => query
                    .Path(NodeAliasPath, PathTypeEnum.Children)
                    .Published(true)
                    .OnSite(SiteContext.CurrentSiteName)
                    .CombineWithDefaultCulture()
                    .OrderBy("NodeOrder")
                    //.Where(x => x.Parent.NodeGUID.ToString() == NodeGUID)
                    .ToList(),
                    cache => cache
                        .Key($"{nameof(HomeRepository)}|{nameof(GetActionLinks)}|{NodeAliasPath}")
                        // Include path dependency to flush cache when a new child page is created or page order is changed.
                        .Dependencies((_, builder) => builder.PagePath(NodeAliasPath, PathTypeEnum.Children).PageOrder()),
                    cancellationToken);
            }
        }
    }
}
