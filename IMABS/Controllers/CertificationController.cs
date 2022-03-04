using CMS.DocumentEngine.Types.IMABS;
using IMABS.Controllers;
using IMABS.Models.Certifications;
using Kentico.Content.Web.Mvc;
using Kentico.Content.Web.Mvc.Routing;
using Microsoft.AspNetCore.Mvc;

[assembly: RegisterPageRoute(Certification.CLASS_NAME, typeof(CertificationController))]
namespace IMABS.Controllers
{
    public class CertificationController : Controller
    {
        private readonly IPageDataContextRetriever dataRetriever;
        private readonly IPageDataContextInitializer pageDataContextInitializer;

        public CertificationController(IPageDataContextRetriever dataRetriever,
            IPageDataContextInitializer _pageDataContextInitializer)
        {
            this.dataRetriever = dataRetriever;
            pageDataContextInitializer = _pageDataContextInitializer;
        }
        /// <summary>
        /// Get the certificate pagetype page
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {
            //Get the current reauested intance of the cetification kind of page type
            var cert = dataRetriever.Retrieve<Certification>().Page;
            if (cert == null)
            {
                return null;
            }
            pageDataContextInitializer.Initialize(cert);

            //view model code
            var model = CertificationViewModel.GetModel(cert);

            model.EnableCallToTactionBanner = model.EnableCallToTactionBanner;
            model.EnablePromotionsBanner = model.EnablePromotionsBanner;
            model.EnableBreadcrumb = model.EnableBreadcrumb;


            return View(model);
        }
    }
}
