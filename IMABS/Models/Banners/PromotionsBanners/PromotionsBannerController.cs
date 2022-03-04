using IMABS.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace IMABS.Models.Banners.PromotionsBanners
{
    public class PromotionsBannerController : Controller
    {
        public ActionResult Index()
        {
            BannersRepository banners = new BannersRepository();
            var page = banners.GetCurrentPromotionsBanner();
            if (page == null)
            {
                return null;
            }

            PromotionsBannerViewModel model = PromotionsBannerViewModel.GetViewModel(page);

            return PartialView("Sections/_PromotionsBanner", model);
        }
    }
}
