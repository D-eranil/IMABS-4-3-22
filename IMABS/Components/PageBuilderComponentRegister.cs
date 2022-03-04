using IMABS.Components;
using IMABS.Components.FormComponents.IconSelectorDropDown;
using IMABS.Components.Sections;
using IMABS.Components.Sections.CallToActionBanner;
using IMABS.Components.Sections.PromotionsBanner;
using IMABS.Components.Sections.ThreeColumnSection;
using IMABS.Components.Widgets.AtAGlance;
using IMABS.Components.Widgets.CTAButton;
using IMABS.Components.Widgets.FeatureWidget;
using IMABS.Components.Widgets.CTATileWidget;
using IMABS.Components.Widgets.ImageCardWidget;
using IMABS.Components.Widgets.SupportWidget;
using IMABS.Components.Widgets.TextWidget;
using IMABS.Components.Widgets.VideoCardWidget;
using Kentico.Forms.Web.Mvc;
using Kentico.PageBuilder.Web.Mvc;
using IMABS.Components.Widgets.ContributionWidget;
using IMABS.Components.Widgets.ContactWidget;
using IMABS.Components.Widgets.HeaderBannerWidget;



//Sections
[assembly: RegisterSection(PagebuilderIdentifiers.THREECOLUMNSECTION_IDENTIFIER, "Three Column Section", typeof(ThreeColumnSectionProperties), customViewName: "~/Components/Sections/ThreeColumnSection/_ThreeColumnSection.cshtml", Description = "Three Column Section", IconClass = "icon-l-cols-3")]

[assembly: RegisterSection(PagebuilderIdentifiers.FOURCOLUMNSECTION_IDENTIFIER, "Four Column Section", typeof(ThemeSectionProperties), "~/Components/Sections/FourColumnSection/_FourColumnColumnSection.cshtml", Description = "Four Column Section", IconClass = "icon-l-cols-4")]

[assembly: RegisterSection(PagebuilderIdentifiers.CTABANNERSECTION_IDENTIFIER, typeof(CallToActionBannerViewComponent), "Call To Action Banner Section", typeof(ThemeSectionProperties), Description = "Call To Action Banner Section", IconClass = "icon-carousel")]

[assembly: RegisterSection(PagebuilderIdentifiers.PROMOBANNERSECTION_IDENTIFIER, typeof(PromotionsBannerViewComponent), "Promotions Banner Section", typeof(ThemeSectionProperties), Description = "Promotions Banner Section", IconClass = "icon-tag")]



//Widget
[assembly: RegisterWidget(PagebuilderIdentifiers.FEATUREWIDGET_IDENTIFIER, typeof(FeatureWidgetViewComponent), "Feature widget", typeof(FeatureWidgetProperties), Description = "Feature widget.", IconClass = "icon-cb-check")]

[assembly: RegisterWidget(PagebuilderIdentifiers.ATAGLANCEWIDGET_IDENTIFIER, typeof(AtAGlanceWidgetViewComponent), "At a glance widget", typeof(AtAGlanceWidgetProperties), Description = "To add stats use this widget.", IconClass = "icon-gauge")]

[assembly: RegisterWidget(PagebuilderIdentifiers.TEXTWIDGET_IDENTIFIER, typeof(TextWidgetViewComponent), "Text widget", typeof(TextWidgetProperties), Description = "Using this widget you can add the text.", IconClass = "icon-l-header-text")]

[assembly: RegisterWidget(PagebuilderIdentifiers.CTABUTTONWIDGET_IDENTIFIER, typeof(CTAButtonWidgetViewComponent), "CTA button widget", typeof(CTAButtonWidgetProperties), Description = "Using this widget to add link button and allot to add css, and redirection link and target window to open link url.", IconClass = "icon-a-lowercase")]

[assembly: RegisterWidget(PagebuilderIdentifiers.SUPPORTWIDGET_IDENTIFIER, typeof(SupportWidgetViewComponent), "Support widget", typeof(SupportWidgetProperties), Description = "Support widget.", IconClass = "icon-picture")]

[assembly: RegisterWidget(PagebuilderIdentifiers.CTATILEWIDGET_IDENTIFIER, typeof(CTATileWidgetViewComponent), "CTA tile widget", typeof(CTATileWidgetProperties), Description = "CTA tile widget.", IconClass = "icon-file")]

[assembly: RegisterFormComponent(PagebuilderIdentifiers.ICONCOMPONENT_IDENTIFIER, typeof(IconSelectorDropDownComponent), "Drop-down with custom Icon data", IconClass = "icon-menu")]

[assembly: RegisterWidget(PagebuilderIdentifiers.VIDEOCARDWIDGET_IDENTIFIER, typeof(VideoCardWidgetVIewComponent), "Video card widget", typeof(VideoCardWidgetProperties), Description = "Video card widget.", IconClass = "icon-camera")]

[assembly: RegisterWidget(PagebuilderIdentifiers.IMAGECARDWIDGET_IDENTIFIER, typeof(ImageCardWidgetViewComponent), "Image card widget", typeof(ImageCardWidgetProperties), Description = "Image card widget.", IconClass = "icon-id-card")]

[assembly: RegisterWidget(PagebuilderIdentifiers.CONTACTWIDGET_IDENTIFIER, typeof(ContactWidgetViewComponent), "Contact widget", typeof(ContactWidgetProperties), Description = "Using this widget you can add the contact tile.", IconClass = "icon-l-list-article")]

[assembly: RegisterWidget(PagebuilderIdentifiers.HEADERBANNERWIDGET_IDENTIFIER, typeof(HeaderBannerWidgetViewComponent), "Header Banner widget", typeof(HeaderBannerWidgetProperties), Description = "Using this widget you can add header with image and text.", IconClass = "icon-rectangle-o-h")]

[assembly: RegisterWidget(PagebuilderIdentifiers.CONTRIBUTIONWIDGET_IDENTIFIER, typeof(ContributionWidgetViewComponent), "Contribution widget", typeof(ContributionWidgetProperties), Description = "Contribution widget.", IconClass = "icon-choice-user-scheme")]
