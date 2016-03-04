///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 4.2
// Code is generated on: 
// Code is generated using templates: SD.TemplateBindings.SharedTemplates
// Templates vendor: Solutions Design.
//////////////////////////////////////////////////////////////
using System;
using System.Collections;
using System.Data;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace SelectAnonymous.DatabaseSpecific
{
	/// <summary>Singleton implementation of the PersistenceInfoProvider. This class is the singleton wrapper through which the actual instance is retrieved.</summary>
	/// <remarks>It uses a single instance of an internal class. The access isn't marked with locks as the PersistenceInfoProviderBase class is threadsafe.</remarks>
	internal static class PersistenceInfoProviderSingleton
	{
		#region Class Member Declarations
		private static readonly IPersistenceInfoProvider _providerInstance = new PersistenceInfoProviderCore();
		#endregion

		/// <summary>Dummy static constructor to make sure threadsafe initialization is performed.</summary>
		static PersistenceInfoProviderSingleton()
		{
		}

		/// <summary>Gets the singleton instance of the PersistenceInfoProviderCore</summary>
		/// <returns>Instance of the PersistenceInfoProvider.</returns>
		public static IPersistenceInfoProvider GetInstance()
		{
			return _providerInstance;
		}
	}

	/// <summary>Actual implementation of the PersistenceInfoProvider. Used by singleton wrapper.</summary>
	internal class PersistenceInfoProviderCore : PersistenceInfoProviderBase
	{
		/// <summary>Initializes a new instance of the <see cref="PersistenceInfoProviderCore"/> class.</summary>
		internal PersistenceInfoProviderCore()
		{
			Init();
		}

		/// <summary>Method which initializes the internal datastores with the structure of hierarchical types.</summary>
		private void Init()
		{
			this.InitClass(2);
			InitStudentEntityMappings();
			InitTeacherEntityMappings();
		}

		/// <summary>Inits StudentEntity's mappings</summary>
		private void InitStudentEntityMappings()
		{
			this.AddElementMapping("StudentEntity", @"SelectAnonymous", @"dbo", "Student", 4, 0);
			this.AddElementFieldMapping("StudentEntity", "AfternoonTeacherId", "afternoonTeacherId", true, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 0);
			this.AddElementFieldMapping("StudentEntity", "Id", "id", false, "Int", 0, 10, 0, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 1);
			this.AddElementFieldMapping("StudentEntity", "MorningTeacherId", "morningTeacherId", true, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 2);
			this.AddElementFieldMapping("StudentEntity", "Name", "name", true, "NVarChar", 127, 0, 0, false, "", null, typeof(System.String), 3);
		}

		/// <summary>Inits TeacherEntity's mappings</summary>
		private void InitTeacherEntityMappings()
		{
			this.AddElementMapping("TeacherEntity", @"SelectAnonymous", @"dbo", "Teacher", 2, 0);
			this.AddElementFieldMapping("TeacherEntity", "Id", "id", false, "Int", 0, 10, 0, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 0);
			this.AddElementFieldMapping("TeacherEntity", "Name", "name", true, "NVarChar", 127, 0, 0, false, "", null, typeof(System.String), 1);
		}

	}
}
