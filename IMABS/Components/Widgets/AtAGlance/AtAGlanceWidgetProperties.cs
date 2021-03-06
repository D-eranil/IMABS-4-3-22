using Kentico.Forms.Web.Mvc;
using Kentico.PageBuilder.Web.Mvc;

namespace IMABS.Components.Widgets.AtAGlance
{
    public class AtAGlanceWidgetProperties : IWidgetProperties
    {
        [EditingComponent(TextInputComponent.IDENTIFIER, Order = 1, Label = "Title")]
        public string Title { get; set; }
        [EditingComponent(TextInputComponent.IDENTIFIER, Order = 2, Label = "Stats (Count)")]
        public string Stats { get; set; }
        [EditingComponent("IMABS.IconSelector", DefaultValue = "", ExplanationText = "", Label = "Select Icon", Order = 3)]
        public string IconClass { get; set; }
    }
}
