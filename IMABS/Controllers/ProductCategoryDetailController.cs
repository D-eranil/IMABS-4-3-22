using Microsoft.AspNetCore.Mvc;
using Kentico.Content.Web.Mvc.Routing;
using CMS.DocumentEngine.Types.IMABS;
using Kentico.Content.Web.Mvc;
using System.Threading.Tasks;
using IMABS.Models.ProductCategories.ProductCategoryDetails;
using IMABS.Controllers;

[assembly: RegisterPageRoute(ProductCategoryDetail.CLASS_NAME, typeof(ProductCategoryDetailController))]
namespace IMABS.Controllers
{
    public class ProductCategoryDetailController : Controller
    {
        private readonly IPageDataContextRetriever dataRetriever;
        private readonly IPageDataContextInitializer pageDataContextInitializer;

        public ProductCategoryDetailController(IPageDataContextRetriever _dataRetriever,
            IPageDataContextInitializer _pageDataContextInitializer
            )
        {
            this.dataRetriever = _dataRetriever;
            this.pageDataContextInitializer = _pageDataContextInitializer;
        }

        /// <summary>
        /// Get Product category detail page based on request path
        /// </summary>
        /// <returns></returns>
        public async Task<ActionResult> Index()
        {
            var productDetailPage = dataRetriever.Retrieve<ProductCategoryDetail>().Page;
            if (productDetailPage == null)
            {
                return null;
            }
            pageDataContextInitializer.Initialize(productDetailPage);

            //Set category model data
            ProductCategoryDetailViewModel model = ProductCategoryDetailViewModel.GetViewModel(productDetailPage);

            model.EnableCallToTactionBanner = productDetailPage.Fields.EnableCallToTactionBanner;
            model.EnablePromotionsBanner = productDetailPage.Fields.EnablePromotionsBanner;
            model.EnableBreadcrumb = productDetailPage.Fields.EnableBreadcrumb;


            return View(model);
        }
    }
}
