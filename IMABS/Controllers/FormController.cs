using Microsoft.AspNetCore.Mvc;
using CMS.DataEngine;
using CMS.OnlineForms;
using CMS.SiteProvider;
using Kentico.Forms.Web.Mvc;

namespace IMABS.Controllers
{
    public class FormController : Controller
    {
        private readonly IFormProvider formProvider;
        private readonly IFormComponentVisibilityEvaluator visibilityEvaluator;
        private readonly IBizFormInfoProvider bizFormInfoProvider;

        public FormController(
          IFormProvider formProvider,
          IFormComponentVisibilityEvaluator visibilityEvaluator,
          IBizFormInfoProvider _bizFormInfoProvider)
        {
            this.formProvider = formProvider;
            this.visibilityEvaluator = visibilityEvaluator;
            this.bizFormInfoProvider = _bizFormInfoProvider;
        }

        // POST: Form/AddResourceDownloadData  
        [HttpPost]
        public string AddResourceDownloadData(ResourceFormField resourceFormField)
        {
            BizFormInfo bizFormInfo = bizFormInfoProvider.Get("Resource", SiteContext.CurrentSiteID);
            if (bizFormInfo != null)
            {
                DataClassInfo formClass = DataClassInfoProvider.GetDataClassInfo(bizFormInfo.FormClassID);
                string formClassName = formClass.ClassName;

                BizFormItem newFormItem = BizFormItem.New(formClassName);
                newFormItem.SetValue("TxtName", resourceFormField.Name);
                newFormItem.SetValue("TxtEmail", resourceFormField.Email);
                newFormItem.SetValue("TxtTitle", resourceFormField.Title);
                newFormItem.SetValue("TxtOrganisation", resourceFormField.Organisation);
                newFormItem.SetValue("chkAgree", (resourceFormField.CheckTerms.ToLower() == "on" ? 1 : 0));
                newFormItem.SetValue("DownloadFile", resourceFormField.DownloadFile);

                newFormItem.Insert();

                return resourceFormField.DownloadFile;
            }
            return string.Empty;
        }
    }

    public class ResourceFormField
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Title { get; set; }
        public string Organisation { get; set; }
        public string CheckTerms { get; set; }
        public string DownloadFile { get; set; }
    }
}
