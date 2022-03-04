using IMABS.Models.Footers;
using IMABS.Models.Headers.MainNavigations;
using IMABS.Repositories;
using Kentico.Content.Web.Mvc;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace IMABS.Components.ViewComponents.Footer
{
    public class FooterViewComponent : ViewComponent
    {
        private readonly HeaderRepository headerRepository;
        public FooterViewComponent(HeaderRepository _headerRepository)
        {
            this.headerRepository = _headerRepository;
        }

        public IViewComponentResult Invoke()
        {
            var header = headerRepository.GetHeaderPage();
            var viewModel = new FooterViewModel
            {
                BottomMenus = headerRepository.GetBottomManus().Select(BottomMenuViewModel.GetViewModel).ToList(),
                FooterLogoUrl = header.Fields.FooterLogo.GetPath(),
                MainMenuDtos = headerRepository.GetFooterMainNavMenus().Select(MainMenuViewModel.GetFooterViewModel).ToList(),
                CopyRightText = header.Fields.CopyRightText,
                FooterLogoText = header.Fields.FooterLogoText,
                FooterTNCText = header.Fields.FooterTNCText
            };

            return View("~/Components/ViewComponents/Footer/Default.cshtml", viewModel);
        }
    }
}
