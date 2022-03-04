using CMS.DocumentEngine.Types.IMABS;
using IMABS.Controllers;
using IMABS.Models.Banners;
using IMABS.Models.Homes;
using IMABS.Models.Homes.HomePopups;
using IMABS.Models.Homes.WhyIngramOptions;
using IMABS.Repositories;
using Kentico.Content.Web.Mvc;
using Kentico.Content.Web.Mvc.Routing;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

//Register page route for routing
[assembly: RegisterPageRoute(Home.CLASS_NAME, typeof(HomeController))]
namespace IMABS.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPageDataContextRetriever pageDataContextRetriever;
        private readonly HomeRepository homeRepository;
        private readonly IPageDataContextInitializer pageDataContextInitializer;

        public HomeController(IPageDataContextRetriever _pageDataContextRetriever,
            HomeRepository _homeRepository,
            IPageDataContextInitializer _pageDataContextInitializer)
        {
            pageDataContextRetriever = _pageDataContextRetriever;
            this.homeRepository = _homeRepository;
            pageDataContextInitializer = _pageDataContextInitializer;
        }

        /// <summary>
        /// Get home page type's detail based on requested url
        /// </summary>
        /// <returns></returns>
        public async Task<IActionResult> Index(CancellationToken cancellationToken)
        {
            // Retrive page of Home page type based on request URL 
            var home = pageDataContextRetriever.Retrieve<Home>().Page;
            if (home == null)
            {
                return null;
            }
            //Initialize home page for page builder options
            pageDataContextInitializer.Initialize(home);

            bool cacheOption = home.Fields.DisableCache;

            var BannerSections = await homeRepository.GetBanners(home.NodeAliasPath, cacheOption, cancellationToken);
            var WhyIngramOptions = await homeRepository.GetWhyIngramOptions(home.NodeAliasPath,cacheOption,cancellationToken);

            HomeViewModel homeView = new HomeViewModel()
            {
                //get banners list
                bannerSections = BannerSections.Select(BannerSectionViewModel.GetViewModel).ToList(),
                //get why ingram section list
                whyIngramOptions = WhyIngramOptions.Select(x=>WhyIngramOptionViewModel.GetViewModel(x,homeRepository, cacheOption,cancellationToken)).ToList(),
                //Get home page popup details
                homePopupDetails = HomePopupViewModel.GetViewModel(HomePopupProvider.GetHomePopups())
            };

            homeView.EnableCallToTactionBanner = home.Fields.EnableCallToTactionBanner;
            homeView.EnablePromotionsBanner = home.Fields.EnablePromotionsBanner;
            homeView.DisableCache = cacheOption;


            return View(homeView);
        }
    }
}
