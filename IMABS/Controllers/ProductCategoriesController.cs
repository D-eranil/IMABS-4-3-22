using CMS.DocumentEngine.Types.IMABS;
using IMABS.Controllers;
using IMABS.Models.ProductCategories;
using IMABS.Models.ProductCategories.ProductCategoryDetails;
using IMABS.Repositories;
using Kentico.Content.Web.Mvc;
using Kentico.Content.Web.Mvc.Routing;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

[assembly: RegisterPageRoute(CategoryIndex.CLASS_NAME, typeof(ProductCategoriesController))]
namespace IMABS.Controllers
{
    public class ProductCategoriesController : Controller
    {
        private readonly IPageDataContextRetriever dataRetriever;
        private readonly IPageDataContextInitializer pageDataContextInitializer;

        public ProductCategoriesController(IPageDataContextRetriever dataRetriever,
        IPageDataContextInitializer _pageDataContextInitializer)
        {
            this.dataRetriever = dataRetriever;
            pageDataContextInitializer = _pageDataContextInitializer;
        }
        public IActionResult Index()
        {
            var categoryPG = dataRetriever.Retrieve<CategoryIndex>().Page;
            if (categoryPG == null)
            {
                return null;
            }
            pageDataContextInitializer.Initialize(categoryPG);
            
            CategoryIndexRepository mCategoryIndexRepository = new CategoryIndexRepository();

            //view model code
            var model = new ProductCategoryViewModel
            {
                productCategoryDetails = mCategoryIndexRepository.GetProductCategoryDetailPages().Select(ProductCategoryDetailViewModel.GetCategoryCardViewModel).ToList()
            };

            model.EnableCallToTactionBanner = categoryPG.Fields.EnableCallToTactionBanner;
            model.EnablePromotionsBanner = categoryPG.Fields.EnablePromotionsBanner;
            model.EnableBreadcrumb = categoryPG.Fields.EnableBreadcrumb;

            return View(model);
        }
    }
}
