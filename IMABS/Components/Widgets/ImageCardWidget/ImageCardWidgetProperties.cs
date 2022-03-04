using Kentico.Components.Web.Mvc.FormComponents;
using Kentico.Forms.Web.Mvc;
using Kentico.PageBuilder.Web.Mvc;
using System.Collections.Generic;

namespace IMABS.Components.Widgets.ImageCardWidget
{
    public class ImageCardWidgetProperties : IWidgetProperties
    {
        /// <summary>
        /// Name to be displayed.
        /// </summary>
        [EditingComponent(TextInputComponent.IDENTIFIER, Order = 1, Label = "Profile name")]
        public string Name { get; set; }

        /// <summary>
        /// Title to be displayed.
        /// </summary>
        [EditingComponent(TextInputComponent.IDENTIFIER, Order = 1, Label = "Profile Title")]
        public string Title { get; set; }



        /// <summary>
        /// Image to be displayed.
        /// </summary>
        /// 
        [EditingComponent(MediaFilesSelector.IDENTIFIER, Order = 2, Label = "Profile Image")]
        [EditingComponentProperty(nameof(MediaFilesSelectorProperties.LibraryName), "IMABS.Media")]
        [EditingComponentProperty(nameof(MediaFilesSelectorProperties.AllowedExtensions), ".gif;.svg;.png;.jpg;.jpeg")]
        [EditingComponentProperty(nameof(MediaFilesSelectorProperties.MaxFilesLimit), 1)]
        public IList<MediaFilesSelectorItem> ProfileImage { get; set; }

        /// <summary>
        /// Button text.
        /// </summary>
        [EditingComponent(TextInputComponent.IDENTIFIER, Order = 3, Label = "Button Text")]
        public string RedirectionButtonText { get; set; }

        /// <summary>
        /// Button redirection URL.
        /// </summary>
        [EditingComponent(TextInputComponent.IDENTIFIER, Order = 4, Label = "Redirection Url")]
        public string RedirectionUrl { get; set; }

        /// <summary>
        /// Bio text contains HTML content
        /// </summary>
        [EditingComponent(RichTextComponent.IDENTIFIER, Order = 4, Label = "Bio text (HTML content)")]
        public string BioText { get; set; }

        /// <summary>
        /// Social media links as HTML content
        /// </summary>
        [EditingComponent(RichTextComponent.IDENTIFIER, Order = 4, Label = "Social medial links (HTML)")]
        public string SocialMediaText { get; set; }

    }
}

