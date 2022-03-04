using CMS.DocumentEngine.Types.IMABS;
using CMS.SiteProvider;
using System.Collections.Generic;
using System.Linq;

namespace IMABS.Repositories
{
    public class CareersRepository
	{
        /// <summary>
        /// get openings
        /// </summary>
        /// <returns>Openings</returns>
        public List<Openings> GetOpenings()
        {
            return OpeningsProvider.GetOpenings()
                .Published(true)
                .OnSite(SiteContext.CurrentSiteName)
                .CombineWithDefaultCulture()
                .OrderBy("NodeOrder")
                .ToList();
        }
    }
}
