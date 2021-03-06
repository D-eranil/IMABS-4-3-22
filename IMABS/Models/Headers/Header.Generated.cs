//--------------------------------------------------------------------------------------------------
// <auto-generated>
//
//     This code was generated by code generator tool.
//
//     To customize the code use your own partial class. For more info about how to use and customize
//     the generated code see the documentation at http://docs.kentico.com.
//
// </auto-generated>
//--------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;

using CMS;
using CMS.Base;
using CMS.Helpers;
using CMS.DataEngine;
using CMS.DocumentEngine.Types.IMABS;
using CMS.DocumentEngine;

[assembly: RegisterDocumentType(Header.CLASS_NAME, typeof(Header))]

namespace CMS.DocumentEngine.Types.IMABS
{
	/// <summary>
	/// Represents a content item of type Header.
	/// </summary>
	public partial class Header : TreeNode
	{
		#region "Constants and variables"

		/// <summary>
		/// The name of the data class.
		/// </summary>
		public const string CLASS_NAME = "IMABS.Header";


		/// <summary>
		/// The instance of the class that provides extended API for working with Header fields.
		/// </summary>
		private readonly HeaderFields mFields;

		#endregion


		#region "Properties"

		/// <summary>
		/// HeaderID.
		/// </summary>
		[DatabaseIDField]
		public int HeaderID
		{
			get
			{
				return ValidationHelper.GetInteger(GetValue("HeaderID"), 0);
			}
			set
			{
				SetValue("HeaderID", value);
			}
		}


		/// <summary>
		/// Header Name.
		/// </summary>
		[DatabaseField]
		public string HeaderName
		{
			get
			{
				return ValidationHelper.GetString(GetValue("HeaderName"), @"");
			}
			set
			{
				SetValue("HeaderName", value);
			}
		}


		/// <summary>
		/// Header Logo.
		/// </summary>
		[DatabaseField]
		public Guid HeaderLogo
		{
			get
			{
				return ValidationHelper.GetGuid(GetValue("HeaderLogo"), Guid.Empty);
			}
			set
			{
				SetValue("HeaderLogo", value);
			}
		}


		/// <summary>
		/// Mobile Header Logo.
		/// </summary>
		[DatabaseField]
		public Guid MobileHeaderLogo
		{
			get
			{
				return ValidationHelper.GetGuid(GetValue("MobileHeaderLogo"), Guid.Empty);
			}
			set
			{
				SetValue("MobileHeaderLogo", value);
			}
		}


		/// <summary>
		/// CTA Button Text.
		/// </summary>
		[DatabaseField]
		public string CTAButtonText
		{
			get
			{
				return ValidationHelper.GetString(GetValue("CTAButtonText"), @"");
			}
			set
			{
				SetValue("CTAButtonText", value);
			}
		}


		/// <summary>
		/// CTA Button Link.
		/// </summary>
		[DatabaseField]
		public string CTAButtonLink
		{
			get
			{
				return ValidationHelper.GetString(GetValue("CTAButtonLink"), @"");
			}
			set
			{
				SetValue("CTAButtonLink", value);
			}
		}


		/// <summary>
		/// Footer Logo.
		/// </summary>
		[DatabaseField]
		public Guid FooterLogo
		{
			get
			{
				return ValidationHelper.GetGuid(GetValue("FooterLogo"), Guid.Empty);
			}
			set
			{
				SetValue("FooterLogo", value);
			}
		}


		/// <summary>
		/// Enter footer copy right text here.
		/// </summary>
		[DatabaseField]
		public string CopyRightText
		{
			get
			{
				return ValidationHelper.GetString(GetValue("CopyRightText"), @"");
			}
			set
			{
				SetValue("CopyRightText", value);
			}
		}


		/// <summary>
		/// Write the text need to be displayed in footer section below the application logo.
		/// </summary>
		[DatabaseField]
		public string FooterLogoText
		{
			get
			{
				return ValidationHelper.GetString(GetValue("FooterLogoText"), @"");
			}
			set
			{
				SetValue("FooterLogoText", value);
			}
		}


		/// <summary>
		/// This text will be displayed under the footer and above the bottom navigation.
		/// </summary>
		[DatabaseField]
		public string FooterTNCText
		{
			get
			{
				return ValidationHelper.GetString(GetValue("FooterTNCText"), @"");
			}
			set
			{
				SetValue("FooterTNCText", value);
			}
		}


		/// <summary>
		/// Gets an object that provides extended API for working with Header fields.
		/// </summary>
		[RegisterProperty]
		public HeaderFields Fields
		{
			get
			{
				return mFields;
			}
		}


		/// <summary>
		/// Provides extended API for working with Header fields.
		/// </summary>
		[RegisterAllProperties]
		public partial class HeaderFields : AbstractHierarchicalObject<HeaderFields>
		{
			/// <summary>
			/// The content item of type Header that is a target of the extended API.
			/// </summary>
			private readonly Header mInstance;


			/// <summary>
			/// Initializes a new instance of the <see cref="HeaderFields" /> class with the specified content item of type Header.
			/// </summary>
			/// <param name="instance">The content item of type Header that is a target of the extended API.</param>
			public HeaderFields(Header instance)
			{
				mInstance = instance;
			}


			/// <summary>
			/// HeaderID.
			/// </summary>
			public int ID
			{
				get
				{
					return mInstance.HeaderID;
				}
				set
				{
					mInstance.HeaderID = value;
				}
			}


			/// <summary>
			/// Header Name.
			/// </summary>
			public string Name
			{
				get
				{
					return mInstance.HeaderName;
				}
				set
				{
					mInstance.HeaderName = value;
				}
			}


			/// <summary>
			/// Header Logo.
			/// </summary>
			public DocumentAttachment Logo
			{
				get
				{
					return mInstance.GetFieldDocumentAttachment("HeaderLogo");
				}
			}


			/// <summary>
			/// Mobile Header Logo.
			/// </summary>
			public DocumentAttachment MobileHeaderLogo
			{
				get
				{
					return mInstance.GetFieldDocumentAttachment("MobileHeaderLogo");
				}
			}


			/// <summary>
			/// CTA Button Text.
			/// </summary>
			public string CTAButtonText
			{
				get
				{
					return mInstance.CTAButtonText;
				}
				set
				{
					mInstance.CTAButtonText = value;
				}
			}


			/// <summary>
			/// CTA Button Link.
			/// </summary>
			public string CTAButtonLink
			{
				get
				{
					return mInstance.CTAButtonLink;
				}
				set
				{
					mInstance.CTAButtonLink = value;
				}
			}


			/// <summary>
			/// Footer Logo.
			/// </summary>
			public DocumentAttachment FooterLogo
			{
				get
				{
					return mInstance.GetFieldDocumentAttachment("FooterLogo");
				}
			}


			/// <summary>
			/// Enter footer copy right text here.
			/// </summary>
			public string CopyRightText
			{
				get
				{
					return mInstance.CopyRightText;
				}
				set
				{
					mInstance.CopyRightText = value;
				}
			}


			/// <summary>
			/// Write the text need to be displayed in footer section below the application logo.
			/// </summary>
			public string FooterLogoText
			{
				get
				{
					return mInstance.FooterLogoText;
				}
				set
				{
					mInstance.FooterLogoText = value;
				}
			}


			/// <summary>
			/// This text will be displayed under the footer and above the bottom navigation.
			/// </summary>
			public string FooterTNCText
			{
				get
				{
					return mInstance.FooterTNCText;
				}
				set
				{
					mInstance.FooterTNCText = value;
				}
			}
		}

		#endregion


		#region "Constructors"

		/// <summary>
		/// Initializes a new instance of the <see cref="Header" /> class.
		/// </summary>
		public Header() : base(CLASS_NAME)
		{
			mFields = new HeaderFields(this);
		}

		#endregion
	}
}