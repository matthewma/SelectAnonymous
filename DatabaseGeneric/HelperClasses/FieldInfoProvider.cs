///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 4.2
// Code is generated on: 
// Code is generated using templates: SD.TemplateBindings.SharedTemplates
// Templates vendor: Solutions Design.
// Templates version: 
//////////////////////////////////////////////////////////////
using System;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace SelectAnonymous.HelperClasses
{
	
	// __LLBLGENPRO_USER_CODE_REGION_START AdditionalNamespaces
	// __LLBLGENPRO_USER_CODE_REGION_END
	
	/// <summary>Singleton implementation of the FieldInfoProvider. This class is the singleton wrapper through which the actual instance is retrieved.</summary>
	/// <remarks>It uses a single instance of an internal class. The access isn't marked with locks as the FieldInfoProviderBase class is threadsafe.</remarks>
	internal static class FieldInfoProviderSingleton
	{
		#region Class Member Declarations
		private static readonly IFieldInfoProvider _providerInstance = new FieldInfoProviderCore();
		#endregion

		/// <summary>Dummy static constructor to make sure threadsafe initialization is performed.</summary>
		static FieldInfoProviderSingleton()
		{
		}

		/// <summary>Gets the singleton instance of the FieldInfoProviderCore</summary>
		/// <returns>Instance of the FieldInfoProvider.</returns>
		public static IFieldInfoProvider GetInstance()
		{
			return _providerInstance;
		}
	}

	/// <summary>Actual implementation of the FieldInfoProvider. Used by singleton wrapper.</summary>
	internal class FieldInfoProviderCore : FieldInfoProviderBase
	{
		/// <summary>Initializes a new instance of the <see cref="FieldInfoProviderCore"/> class.</summary>
		internal FieldInfoProviderCore()
		{
			Init();
		}

		/// <summary>Method which initializes the internal datastores.</summary>
		private void Init()
		{
			this.InitClass( (2 + 0));
			InitStudentEntityInfos();
			InitTeacherEntityInfos();

			this.ConstructElementFieldStructures(InheritanceInfoProviderSingleton.GetInstance());
		}

		/// <summary>Inits StudentEntity's FieldInfo objects</summary>
		private void InitStudentEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(StudentFieldIndex), "StudentEntity");
			this.AddElementFieldInfo("StudentEntity", "AfternoonTeacherId", typeof(Nullable<System.Int32>), false, false, false, true,  (int)StudentFieldIndex.AfternoonTeacherId, 0, 0, 10);
			this.AddElementFieldInfo("StudentEntity", "Id", typeof(System.Int32), true, false, true, false,  (int)StudentFieldIndex.Id, 0, 0, 10);
			this.AddElementFieldInfo("StudentEntity", "MorningTeacherId", typeof(Nullable<System.Int32>), false, false, false, true,  (int)StudentFieldIndex.MorningTeacherId, 0, 0, 10);
			this.AddElementFieldInfo("StudentEntity", "Name", typeof(System.String), false, false, false, true,  (int)StudentFieldIndex.Name, 127, 0, 0);
		}
		/// <summary>Inits TeacherEntity's FieldInfo objects</summary>
		private void InitTeacherEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(TeacherFieldIndex), "TeacherEntity");
			this.AddElementFieldInfo("TeacherEntity", "Id", typeof(System.Int32), true, false, true, false,  (int)TeacherFieldIndex.Id, 0, 0, 10);
			this.AddElementFieldInfo("TeacherEntity", "Name", typeof(System.String), false, false, false, true,  (int)TeacherFieldIndex.Name, 127, 0, 0);
		}
		
	}
}




