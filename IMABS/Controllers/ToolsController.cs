using CMS.DocumentEngine.Types.IMABS;
using IMABS.Controllers;
using IMABS.Models.Tool;
using Kentico.Content.Web.Mvc;
using Kentico.Content.Web.Mvc.Routing;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

[assembly: RegisterPageRoute(Tools.CLASS_NAME, typeof(ToolsController))]
namespace IMABS.Controllers
{
    public class ToolsController : Controller
    {
        private readonly IPageDataContextRetriever pageDataContextRetriever;
        private readonly IPageDataContextInitializer pageDataContextInitializer;

        public ToolsController(IPageDataContextRetriever _pageDataContextRetriever,
            IPageDataContextInitializer _pageDataContextInitializer)
        {
            pageDataContextRetriever = _pageDataContextRetriever;
            pageDataContextInitializer = _pageDataContextInitializer;
        }
        public async Task<ActionResult> Index()
        {
            var tools = pageDataContextRetriever.Retrieve<Tools>().Page;

            //view model code
            var model = ToolsViewModel.GetViewModel(tools);

            model.EnableCallToTactionBanner = tools.Fields.EnableCallToTactionBanner;
            model.EnablePromotionsBanner = tools.Fields.EnablePromotionsBanner;
            model.EnableBreadcrumb = tools.Fields.EnableBreadcrumb;

            pageDataContextInitializer.Initialize(tools);

            return View(tools);
        }
    }
}
