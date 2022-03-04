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

[assembly: RegisterDocumentType(ContactUsSection.CLASS_NAME, typeof(ContactUsSection))]

namespace CMS.DocumentEngine.Types.IMABS
{
	/// <summary>
	/// Represents a content item of type ContactUsSection.
	/// </summary>
	public partial class ContactUsSection : TreeNode
	{
		#region "Constants and variables"

		/// <summary>
		/// The name of the data class.
		/// </summary>
		public const string CLASS_NAME = "IMABS.ContactUsSection";


		/// <summary>
		/// The instance of the class that provides extended API for working with ContactUsSection fields.
		/// </summary>
		private readonly ContactUsSectionFields mFields;

		#endregion


		#region "Properties"

		/// <summary>
		/// ContactUsSectionID.
		/// </summary>
		[DatabaseIDField]
		public int ContactUsSectionID
		{
			get
			{
				return ValidationHelper.GetInteger(GetValue("ContactUsSectionID"), 0);
			}
			set
			{
				SetValue("ContactUsSectionID", value);
			}
		}


		/// <summary>
		/// Section Name.
		/// </summary>
		[DatabaseField]
		public string SectionName
		{
			get
			{
				return ValidationHelper.GetString(GetValue("SectionName"), @"");
			}
			set
			{
				SetValue("SectionName", value);
			}
		}


		/// <summary>
		/// Short Description.
		/// </summary>
		[DatabaseField]
		public string ShortDescription
		{
			get
			{
				return ValidationHelper.GetString(GetValue("ShortDescription"), @"");
			}
			set
			{
				SetValue("ShortDescription", value);
			}
		}


		/// <summary>
		/// Section Detail.
		/// </summary>
		[DatabaseField]
		public string SectionDetail
		{
			get
			{
				return ValidationHelper.GetString(GetValue("SectionDetail"), @"");
			}
			set
			{
				SetValue("SectionDetail", value);
			}
		}


		/// <summary>
		/// Background.
		/// </summary>
		[DatabaseField]
		public string SectionBackground
		{
			get
			{
				return ValidationHelper.GetString(GetValue("SectionBackground"), @"");
			}
			set
			{
				SetValue("SectionBackground", value);
			}
		}


		/// <summary>
		/// Gets an object that provides extended API for working with ContactUsSection fields.
		/// </summary>
		[RegisterProperty]
		public ContactUsSectionFields Fields
		{
			get
			{
				return mFields;
			}
		}


		/// <summary>
		/// Provides extended API for working with ContactUsSection fields.
		/// </summary>
		[RegisterAllProperties]
		public partial class ContactUsSectionFields : AbstractHierarchicalObject<ContactUsSectionFields>
		{
			/// <summary>
			/// The content item of type ContactUsSection that is a target of the extended API.
			/// </summary>
			private readonly ContactUsSection mInstance;


			/// <summary>
			/// Initializes a new instance of the <see cref="ContactUsSectionFields" /> class with the specified content item of type ContactUsSection.
			/// </summary>
			/// <param name="instance">The content item of type ContactUsSection that is a target of the extended API.</param>
			public ContactUsSectionFields(ContactUsSection instance)
			{
				mInstance = instance;
			}


			/// <summary>
			/// ContactUsSectionID.
			/// </summary>
			public int ID
			{
				get
				{
					return mInstance.ContactUsSectionID;
				}
				set
				{
					mInstance.ContactUsSectionID = value;
				}
			}


			/// <summary>
			/// Section Name.
			/// </summary>
			public string SectionName
			{
				get
				{
					return mInstance.SectionName;
				}
				set
				{
					mInstance.SectionName = value;
				}
			}


			/// <summary>
			/// Short Description.
			/// </summary>
			public string ShortDescription
			{
				get
				{
					return mInstance.ShortDescription;
				}
				set
				{
					mInstance.ShortDescription = value;
				}
			}


			/// <summary>
			/// Section Detail.
			/// </summary>
			public string SectionDetail
			{
				get
				{
					return mInstance.SectionDetail;
				}
				set
				{
					mInstance.SectionDetail = value;
				}
			}


			/// <summary>
			/// Background.
			/// </summary>
			public string SectionBackground
			{
				get
				{
					return mInstance.SectionBackground;
				}
				set
				{
					mInstance.SectionBackground = value;
				}
			}
		}

		#endregion


		#region "Constructors"

		/// <summary>
		/// Initializes a new instance of the <see cref="ContactUsSection" /> class.
		/// </summary>
		public ContactUsSection() : base(CLASS_NAME)
		{
			mFields = new ContactUsSectionFields(this);
		}

		#endregion
	}
}