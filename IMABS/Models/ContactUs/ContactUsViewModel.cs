using System.Collections.Generic;

namespace IMABS.Models.ContactUs
{
	public class ContactUsViewModel : CommonSettingsViewModel
	{
		public string Title { get; set; }
		public List<ContactUsSectionViewModel> contactUsSections { get; set; }
	}
}
