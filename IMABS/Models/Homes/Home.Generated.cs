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

[assembly: RegisterDocumentType(Home.CLASS_NAME, typeof(Home))]

namespace CMS.DocumentEngine.Types.IMABS
{
	/// <summary>
	/// Represents a content item of type Home.
	/// </summary>
	public partial class Home : TreeNode
	{
		#region "Constants and variables"

		/// <summary>
		/// The name of the data class.
		/// </summary>
		public const string CLASS_NAME = "IMABS.Home";


		/// <summary>
		/// The instance of the class that provides extended API for working with Home fields.
		/// </summary>
		private readonly HomeFields mFields;

		#endregion


		#region "Properties"

		/// <summary>
		/// HomeID.
		/// </summary>
		[DatabaseIDField]
		public int HomeID
		{
			get
			{
				return ValidationHelper.GetInteger(GetValue("HomeID"), 0);
			}
			set
			{
				SetValue("HomeID", value);
			}
		}


		/// <summary>
		/// Name.
		/// </summary>
		[DatabaseField]
		public string HomeName
		{
			get
			{
				return ValidationHelper.GetString(GetValue("HomeName"), @"");
			}
			set
			{
				SetValue("HomeName", value);
			}
		}


		/// <summary>
		/// Enable CTA banner?.
		/// </summary>
		[DatabaseField]
		public bool EnableCallToTactionBanner
		{
			get
			{
				return ValidationHelper.GetBoolean(GetValue("EnableCallToTactionBanner"), false);
			}
			set
			{
				SetValue("EnableCallToTactionBanner", value);
			}
		}


		/// <summary>
		/// Enable promotions banner?.
		/// </summary>
		[DatabaseField]
		public bool EnablePromotionsBanner
		{
			get
			{
				return ValidationHelper.GetBoolean(GetValue("EnablePromotionsBanner"), false);
			}
			set
			{
				SetValue("EnablePromotionsBanner", value);
			}
		}


		/// <summary>
		/// Enable Breadcrumb?.
		/// </summary>
		[DatabaseField]
		public bool EnableBreadcrumb
		{
			get
			{
				return ValidationHelper.GetBoolean(GetValue("EnableBreadcrumb"), false);
			}
			set
			{
				SetValue("EnableBreadcrumb", value);
			}
		}


		/// <summary>
		/// Disable cache.
		/// </summary>
		[DatabaseField]
		public bool DisableCache
		{
			get
			{
				return ValidationHelper.GetBoolean(GetValue("DisableCache"), false);
			}
			set
			{
				SetValue("DisableCache", value);
			}
		}


		/// <summary>
		/// Show in header menu.
		/// </summary>
		[DatabaseField]
		public bool AllowToViewInHeader
		{
			get
			{
				return ValidationHelper.GetBoolean(GetValue("AllowToViewInHeader"), true);
			}
			set
			{
				SetValue("AllowToViewInHeader", value);
			}
		}


		/// <summary>
		/// Show in footer menu.
		/// </summary>
		[DatabaseField]
		public bool AllowToViewInFooter
		{
			get
			{
				return ValidationHelper.GetBoolean(GetValue("AllowToViewInFooter"), true);
			}
			set
			{
				SetValue("AllowToViewInFooter", value);
			}
		}


		/// <summary>
		/// Gets an object that provides extended API for working with Home fields.
		/// </summary>
		[RegisterProperty]
		public HomeFields Fields
		{
			get
			{
				return mFields;
			}
		}


		/// <summary>
		/// Provides extended API for working with Home fields.
		/// </summary>
		[RegisterAllProperties]
		public partial class HomeFields : AbstractHierarchicalObject<HomeFields>
		{
			/// <summary>
			/// The content item of type Home that is a target of the extended API.
			/// </summary>
			private readonly Home mInstance;


			/// <summary>
			/// Initializes a new instance of the <see cref="HomeFields" /> class with the specified content item of type Home.
			/// </summary>
			/// <param name="instance">The content item of type Home that is a target of the extended API.</param>
			public HomeFields(Home instance)
			{
				mInstance = instance;
			}


			/// <summary>
			/// HomeID.
			/// </summary>
			public int ID
			{
				get
				{
					return mInstance.HomeID;
				}
				set
				{
					mInstance.HomeID = value;
				}
			}


			/// <summary>
			/// Name.
			/// </summary>
			public string Name
			{
				get
				{
					return mInstance.HomeName;
				}
				set
				{
					mInstance.HomeName = value;
				}
			}


			/// <summary>
			/// Enable CTA banner?.
			/// </summary>
			public bool EnableCallToTactionBanner
			{
				get
				{
					return mInstance.EnableCallToTactionBanner;
				}
				set
				{
					mInstance.EnableCallToTactionBanner = value;
				}
			}


			/// <summary>
			/// Enable promotions banner?.
			/// </summary>
			public bool EnablePromotionsBanner
			{
				get
				{
					return mInstance.EnablePromotionsBanner;
				}
				set
				{
					mInstance.EnablePromotionsBanner = value;
				}
			}


			/// <summary>
			/// Enable Breadcrumb?.
			/// </summary>
			public bool EnableBreadcrumb
			{
				get
				{
					return mInstance.EnableBreadcrumb;
				}
				set
				{
					mInstance.EnableBreadcrumb = value;
				}
			}


			/// <summary>
			/// Disable cache.
			/// </summary>
			public bool DisableCache
			{
				get
				{
					return mInstance.DisableCache;
				}
				set
				{
					mInstance.DisableCache = value;
				}
			}


			/// <summary>
			/// Show in header menu.
			/// </summary>
			public bool AllowToViewInHeader
			{
				get
				{
					return mInstance.AllowToViewInHeader;
				}
				set
				{
					mInstance.AllowToViewInHeader = value;
				}
			}


			/// <summary>
			/// Show in footer menu.
			/// </summary>
			public bool AllowToViewInFooter
			{
				get
				{
					return mInstance.AllowToViewInFooter;
				}
				set
				{
					mInstance.AllowToViewInFooter = value;
				}
			}
		}

		#endregion


		#region "Constructors"

		/// <summary>
		/// Initializes a new instance of the <see cref="Home" /> class.
		/// </summary>
		public Home() : base(CLASS_NAME)
		{
			mFields = new HomeFields(this);
		}

		#endregion
	}
}