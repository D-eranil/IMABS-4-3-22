using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;

namespace IMABS.Components.Widgets.AtAGlance
{
    public class AtAGlanceWidgetViewComponent : ViewComponent
    {

        // GET: FeatureWidget
        public ViewViewComponentResult Invoke(AtAGlanceWidgetProperties properties)
        {

            return View("~/Components/Widgets/AtAGlance/_AtAGlanceWidget.cshtml", new AtAGlanceViewModel
            {
                IconClass = properties.IconClass,
                Title = properties.Title,
                Stats = properties.Stats
            });
        }
    }
}
