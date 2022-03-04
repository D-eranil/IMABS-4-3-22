using CMS.DocumentEngine.Types.IMABS;
using Kentico.Content.Web.Mvc;

namespace IMABS.Models.Homes.PartnerCentrals
{
    public class PartnerCentralViewModel
    {
        public string Title { get; set; }
        public string SubTitle { get; set; }
        public string CTAButtonText { get; set; }
        public string CTAButtonLink { get; set; }
        public string ImageUrl { get; set; }

        public static PartnerCentralViewModel GetViewModel(PartnerCentral partnerCentral)
        {
            return partnerCentral == null ? null : new PartnerCentralViewModel
            {
                CTAButtonLink = partnerCentral.Fields.CTAButtonLink,
                CTAButtonText = partnerCentral.Fields.CTAButtonText,
                ImageUrl = partnerCentral.Fields.Image.GetPath(),
                SubTitle = partnerCentral.Fields.SubTItle,
                Title = partnerCentral.Fields.Title
            };
        }
    }
}
