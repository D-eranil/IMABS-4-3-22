using CMS.DocumentEngine.Types.IMABS;
using IMABS.Controllers;
using IMABS.Models.FeatureTemplates;
using Kentico.Content.Web.Mvc;
using Kentico.Content.Web.Mvc.Routing;
using Microsoft.AspNetCore.Mvc;

[assembly: RegisterPageRoute(FeatureTemplate.CLASS_NAME, typeof(FeatureTemplateController))]
namespace IMABS.Controllers
{
    public class FeatureTemplateController : Controller
    {
        private readonly IPageDataContextRetriever dataRetriever;
        private readonly IPageDataContextInitializer pageDataContextInitializer;

        public FeatureTemplateController(IPageDataContextRetriever dataRetriever,
        IPageDataContextInitializer _pageDataContextInitializer)
        {
            this.dataRetriever = dataRetriever;
            pageDataContextInitializer = _pageDataContextInitializer;
        }
        public IActionResult Index()
        {
            var ft = dataRetriever.Retrieve<FeatureTemplate>().Page;
            if (ft == null)
            {
                return null;
            }
            pageDataContextInitializer.Initialize(ft);


            //view model code
            var model = FeatureTemplateViewModel.GetViewModel(ft);
            

            model.EnableCallToTactionBanner = ft.Fields.EnableCallToTactionBanner;
            model.EnablePromotionsBanner = ft.Fields.EnablePromotionsBanner;
            model.EnableBreadcrumb = ft.Fields.EnableBreadcrumb;

            return View(model);
        }
    }
}
