﻿//--------------------------------------------------------------------------------------------------
// <auto-generated>
//
//     This code was generated by code generator tool.
//
//     To customize the code use your own partial class. For more info about how to use and customize
//     the generated code see the documentation at https://docs.xperience.io/.
//
// </auto-generated>
//--------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using CMS;
using CMS.Base;
using CMS.Helpers;
using CMS.DataEngine;
using CMS.DocumentEngine;
using CMS.DocumentEngine.Types.IMABS;

[assembly: RegisterDocumentType(HomePopup.CLASS_NAME, typeof(HomePopup))]

namespace CMS.DocumentEngine.Types.IMABS
{
	/// <summary>
	/// Represents a content item of type HomePopup.
	/// </summary>
	public partial class HomePopup : TreeNode
	{
		#region "Constants and variables"

		/// <summary>
		/// The name of the data class.
		/// </summary>
		public const string CLASS_NAME = "IMABS.HomePopup";


		/// <summary>
		/// The instance of the class that provides extended API for working with HomePopup fields.
		/// </summary>
		private readonly HomePopupFields mFields;

		#endregion


		#region "Properties"

		/// <summary>
		/// HomePopupID.
		/// </summary>
		[DatabaseIDField]
		public int HomePopupID
		{
			get
			{
				return ValidationHelper.GetInteger(GetValue("HomePopupID"), 0);
			}
			set
			{
				SetValue("HomePopupID", value);
			}
		}


		/// <summary>
		/// Name.
		/// </summary>
		[DatabaseField]
		public string Name
		{
			get
			{
				return ValidationHelper.GetString(GetValue("Name"), @"");
			}
			set
			{
				SetValue("Name", value);
			}
		}


		/// <summary>
		/// Heading.
		/// </summary>
		[DatabaseField]
		public string Heading
		{
			get
			{
				return ValidationHelper.GetString(GetValue("Heading"), @"");
			}
			set
			{
				SetValue("Heading", value);
			}
		}


		/// <summary>
		/// Image.
		/// </summary>
		[DatabaseField]
		public string Image
		{
			get
			{
				return ValidationHelper.GetString(GetValue("Image"), @"");
			}
			set
			{
				SetValue("Image", value);
			}
		}


		/// <summary>
		/// Site link text.
		/// </summary>
		[DatabaseField]
		public string SiteLinkText
		{
			get
			{
				return ValidationHelper.GetString(GetValue("SiteLinkText"), @"");
			}
			set
			{
				SetValue("SiteLinkText", value);
			}
		}


		/// <summary>
		/// Site link.
		/// </summary>
		[DatabaseField]
		public string SiteLink
		{
			get
			{
				return ValidationHelper.GetString(GetValue("SiteLink"), @"");
			}
			set
			{
				SetValue("SiteLink", value);
			}
		}


		/// <summary>
		/// Find out more link text.
		/// </summary>
		[DatabaseField]
		public string FindoutMoreLinkText
		{
			get
			{
				return ValidationHelper.GetString(GetValue("FindoutMoreLinkText"), @"");
			}
			set
			{
				SetValue("FindoutMoreLinkText", value);
			}
		}


		/// <summary>
		/// Find out more link.
		/// </summary>
		[DatabaseField]
		public string FindoutMoreLink
		{
			get
			{
				return ValidationHelper.GetString(GetValue("FindoutMoreLink"), @"");
			}
			set
			{
				SetValue("FindoutMoreLink", value);
			}
		}


		/// <summary>
		/// View Layout.
		/// </summary>
		[DatabaseField]
		public bool ViewLayout
		{
			get
			{
				return ValidationHelper.GetBoolean(GetValue("ViewLayout"), false);
			}
			set
			{
				SetValue("ViewLayout", value);
			}
		}


		/// <summary>
		/// Popup layout HTML.
		/// </summary>
		[DatabaseField]
		public string LayoutHtml
		{
			get
			{
				return ValidationHelper.GetString(GetValue("LayoutHtml"), @"");
			}
			set
			{
				SetValue("LayoutHtml", value);
			}
		}


		/// <summary>
		/// Gets an object that provides extended API for working with HomePopup fields.
		/// </summary>
		[RegisterProperty]
		public HomePopupFields Fields
		{
			get
			{
				return mFields;
			}
		}


		/// <summary>
		/// Provides extended API for working with HomePopup fields.
		/// </summary>
		[RegisterAllProperties]
		public partial class HomePopupFields : AbstractHierarchicalObject<HomePopupFields>
		{
			/// <summary>
			/// The content item of type HomePopup that is a target of the extended API.
			/// </summary>
			private readonly HomePopup mInstance;


			/// <summary>
			/// Initializes a new instance of the <see cref="HomePopupFields" /> class with the specified content item of type HomePopup.
			/// </summary>
			/// <param name="instance">The content item of type HomePopup that is a target of the extended API.</param>
			public HomePopupFields(HomePopup instance)
			{
				mInstance = instance;
			}


			/// <summary>
			/// HomePopupID.
			/// </summary>
			public int ID
			{
				get
				{
					return mInstance.HomePopupID;
				}
				set
				{
					mInstance.HomePopupID = value;
				}
			}


			/// <summary>
			/// Name.
			/// </summary>
			public string Name
			{
				get
				{
					return mInstance.Name;
				}
				set
				{
					mInstance.Name = value;
				}
			}


			/// <summary>
			/// Heading.
			/// </summary>
			public string Heading
			{
				get
				{
					return mInstance.Heading;
				}
				set
				{
					mInstance.Heading = value;
				}
			}


			/// <summary>
			/// Image.
			/// </summary>
			public string Image
			{
				get
				{
					return mInstance.Image;
				}
				set
				{
					mInstance.Image = value;
				}
			}


			/// <summary>
			/// Site link text.
			/// </summary>
			public string SiteLinkText
			{
				get
				{
					return mInstance.SiteLinkText;
				}
				set
				{
					mInstance.SiteLinkText = value;
				}
			}


			/// <summary>
			/// Site link.
			/// </summary>
			public string SiteLink
			{
				get
				{
					return mInstance.SiteLink;
				}
				set
				{
					mInstance.SiteLink = value;
				}
			}


			/// <summary>
			/// Find out more link text.
			/// </summary>
			public string FindoutMoreLinkText
			{
				get
				{
					return mInstance.FindoutMoreLinkText;
				}
				set
				{
					mInstance.FindoutMoreLinkText = value;
				}
			}


			/// <summary>
			/// Find out more link.
			/// </summary>
			public string FindoutMoreLink
			{
				get
				{
					return mInstance.FindoutMoreLink;
				}
				set
				{
					mInstance.FindoutMoreLink = value;
				}
			}


			/// <summary>
			/// View Layout.
			/// </summary>
			public bool ViewLayout
			{
				get
				{
					return mInstance.ViewLayout;
				}
				set
				{
					mInstance.ViewLayout = value;
				}
			}


			/// <summary>
			/// Popup layout HTML.
			/// </summary>
			public string LayoutHtml
			{
				get
				{
					return mInstance.LayoutHtml;
				}
				set
				{
					mInstance.LayoutHtml = value;
				}
			}
		}

		#endregion


		#region "Constructors"

		/// <summary>
		/// Initializes a new instance of the <see cref="HomePopup" /> class.
		/// </summary>
		public HomePopup() : base(CLASS_NAME)
		{
			mFields = new HomePopupFields(this);
		}

		#endregion
	}
}