using CMS.DocumentEngine;
using CMS.DocumentEngine.Types.IMABS;
using IMABS.Helpers;
using System.Linq;

namespace IMABS.Models.Headers.SubNavigations
{
    public class SubMenuViewModel
    {
        public string SubNavigationItemName { get; set; }
        public string SubNavigationItemUrl { get; set; }
        public int SubNavigationLinkLevelId { get; set; }
        public int SubNavigationLinkParentId { get; set; }
        public bool AllowToViewInFooter { get; set; }
        public bool AllowToViewInHeader { get; set; }
        public bool HasChildren { get; set; }


        public static SubMenuViewModel GetViewModel(SubNavigation subNavigation)
        {
            return subNavigation == null ? null : new SubMenuViewModel
            {
                SubNavigationItemName = subNavigation.Fields.ItemName,
                SubNavigationItemUrl = subNavigation.Fields.ItemUrl,
                HasChildren = subNavigation.NodeHasChildren
            };
        }


        public static SubMenuViewModel GetViewModel(TreeNode page)
        {
            if (page.ClassName == ServiceTemplateTitle.CLASS_NAME)
                return new SubMenuViewModel();
            var smartphones = new DocumentQuery(page.ClassName)
                        .OnCurrentSite()
                        .Culture(page.DocumentCulture)
                        .Path(page.NodeAliasPath)
                        .LatestVersion().TopN(1)
                        .Where("AllowToViewInHeader", CMS.DataEngine.QueryOperator.Equals, true)
                        .Tables[0];


            SubMenuViewModel SubMenuViewModel = DataTableToDtoClassHelper.CreateListFromTable<SubMenuViewModel>(smartphones).FirstOrDefault();
            if (SubMenuViewModel == null)
            {
                SubMenuViewModel = new SubMenuViewModel();
            }

            return page == null ? null : new SubMenuViewModel
            {
                SubNavigationItemName = page.DocumentName,
                SubNavigationItemUrl = page.NodeAliasPath,
                AllowToViewInFooter = SubMenuViewModel.AllowToViewInFooter,
                AllowToViewInHeader = SubMenuViewModel.AllowToViewInHeader,
                HasChildren = page.NodeHasChildren
            };
        }

        public static SubMenuViewModel GetFooterViewModel(TreeNode page)
        {
            if (page.ClassName == ServiceTemplateTitle.CLASS_NAME )
                return new SubMenuViewModel();
            var smartphones = new DocumentQuery(page.ClassName)
                        .OnCurrentSite()
                        .Culture(page.DocumentCulture)
                        .Path(page.NodeAliasPath)
                        .LatestVersion().TopN(1)
                        .Where("AllowToViewInFooter", CMS.DataEngine.QueryOperator.Equals, true)
                        .Tables[0];


            SubMenuViewModel subMenuDto = DataTableToDtoClassHelper.CreateListFromTable<SubMenuViewModel>(smartphones).FirstOrDefault();
            if (subMenuDto == null)
            {
                subMenuDto = new SubMenuViewModel();
            }

            return page == null ? null : new SubMenuViewModel
            {
                SubNavigationItemName = page.DocumentName,
                SubNavigationItemUrl = page.NodeAliasPath,
                AllowToViewInFooter = subMenuDto.AllowToViewInFooter,
                AllowToViewInHeader = subMenuDto.AllowToViewInHeader,
                HasChildren = page.NodeHasChildren
            };

        }
    }
}
