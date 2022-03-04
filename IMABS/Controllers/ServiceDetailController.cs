using CMS.DocumentEngine.Types.IMABS;
using IMABS.Controllers;
using IMABS.Models.Service;
using IMABS.Repositories;
using Kentico.Content.Web.Mvc;
using Kentico.Content.Web.Mvc.Routing;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

[assembly: RegisterPageRoute(Services.CLASS_NAME, typeof(ServiceDetailController))]
namespace IMABS.Controllers
{
    public class ServiceDetailController : Controller
	{
		private readonly IPageDataContextRetriever dataRetriever;
		private readonly ServicesRepository mServicesRepository;
		private readonly IPageDataContextInitializer pageDataContextInitializer;

		public ServiceDetailController(IPageDataContextRetriever dataRetriever,
            ServicesRepository servicesRepository,
			IPageDataContextInitializer _pageDataContextInitializer)
		{
			this.dataRetriever = dataRetriever;
            mServicesRepository = servicesRepository;
			pageDataContextInitializer = _pageDataContextInitializer;
		}
        // GET: Services
        public async Task<ActionResult> Index(string NodeAliasPath)
        {
            var serviceDetailPage = dataRetriever.Retrieve<Services>().Page;
            if (serviceDetailPage == null)
            {
                return null;
            }
            pageDataContextInitializer.Initialize(serviceDetailPage);

            //view model code
            var model = ServiceViewModel.GetPageViewModel(serviceDetailPage);

            model.EnableBreadcrumb = serviceDetailPage.Fields.EnableBreadcrumb;

            return View(model);
        }
    }
}
