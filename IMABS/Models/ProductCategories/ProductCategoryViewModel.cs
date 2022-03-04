using IMABS.Models.ProductCategories.ProductCategoryDetails;
using System.Collections.Generic;

namespace IMABS.Models.ProductCategories
{
    public class ProductCategoryViewModel : CommonSettingsViewModel
    {
        public List<ProductCategoryDetailViewModel> productCategoryDetails { get; set; }
    }
}
