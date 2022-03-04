//--------------------------------------------------------------------------------------------------
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

[assembly: RegisterDocumentType(Careers.CLASS_NAME, typeof(Careers))]

namespace CMS.DocumentEngine.Types.IMABS
{
	/// <summary>
	/// Represents a content item of type Careers.
	/// </summary>
	public partial class Careers : TreeNode
	{
		#region "Constants and variables"

		/// <summary>
		/// The name of the data class.
		/// </summary>
		public const string CLASS_NAME = "IMABS.Careers";


		/// <summary>
		/// The instance of the class that provides extended API for working with Careers fields.
		/// </summary>
		private readonly CareersFields mFields;

		#endregion


		#region "Properties"

		/// <summary>
		/// CareersID.
		/// </summary>
		[DatabaseIDField]
		public int CareersID
		{
			get
			{
				return ValidationHelper.GetInteger(GetValue("CareersID"), 0);
			}
			set
			{
				SetValue("CareersID", value);
			}
		}


		/// <summary>
		/// Title.
		/// </summary>
		[DatabaseField]
		public string CareerTitle
		{
			get
			{
				return ValidationHelper.GetString(GetValue("CareerTitle"), @"");
			}
			set
			{
				SetValue("CareerTitle", value);
			}
		}


		/// <summary>
		/// Find Us Title.
		/// </summary>
		[DatabaseField]
		public string FindUsTitle
		{
			get
			{
				return ValidationHelper.GetString(GetValue("FindUsTitle"), @"");
			}
			set
			{
				SetValue("FindUsTitle", value);
			}
		}


		/// <summary>
		/// Follow Us Title.
		/// </summary>
		[DatabaseField]
		public string FollowUsTitle
		{
			get
			{
				return ValidationHelper.GetString(GetValue("FollowUsTitle"), @"");
			}
			set
			{
				SetValue("FollowUsTitle", value);
			}
		}


		/// <summary>
		/// Select Social Media.
		/// </summary>
		[DatabaseField]
		public string SocialMediaSelector
		{
			get
			{
				return ValidationHelper.GetString(GetValue("SocialMediaSelector"), @"");
			}
			set
			{
				SetValue("SocialMediaSelector", value);
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
		/// Gets an object that provides extended API for working with Careers fields.
		/// </summary>
		[RegisterProperty]
		public CareersFields Fields
		{
			get
			{
				return mFields;
			}
		}


		/// <summary>
		/// Provides extended API for working with Careers fields.
		/// </summary>
		[RegisterAllProperties]
		public partial class CareersFields : AbstractHierarchicalObject<CareersFields>
		{
			/// <summary>
			/// The content item of type Careers that is a target of the extended API.
			/// </summary>
			private readonly Careers mInstance;


			/// <summary>
			/// Initializes a new instance of the <see cref="CareersFields" /> class with the specified content item of type Careers.
			/// </summary>
			/// <param name="instance">The content item of type Careers that is a target of the extended API.</param>
			public CareersFields(Careers instance)
			{
				mInstance = instance;
			}


			/// <summary>
			/// CareersID.
			/// </summary>
			public int ID
			{
				get
				{
					return mInstance.CareersID;
				}
				set
				{
					mInstance.CareersID = value;
				}
			}


			/// <summary>
			/// Title.
			/// </summary>
			public string CareerTitle
			{
				get
				{
					return mInstance.CareerTitle;
				}
				set
				{
					mInstance.CareerTitle = value;
				}
			}


			/// <summary>
			/// Find Us Title.
			/// </summary>
			public string FindUsTitle
			{
				get
				{
					return mInstance.FindUsTitle;
				}
				set
				{
					mInstance.FindUsTitle = value;
				}
			}


			/// <summary>
			/// Follow Us Title.
			/// </summary>
			public string FollowUsTitle
			{
				get
				{
					return mInstance.FollowUsTitle;
				}
				set
				{
					mInstance.FollowUsTitle = value;
				}
			}


			/// <summary>
			/// Select Social Media.
			/// </summary>
			public string SocialMediaSelector
			{
				get
				{
					return mInstance.SocialMediaSelector;
				}
				set
				{
					mInstance.SocialMediaSelector = value;
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
		/// Initializes a new instance of the <see cref="Careers" /> class.
		/// </summary>
		public Careers() : base(CLASS_NAME)
		{
			mFields = new CareersFields(this);
		}

		#endregion
	}
}