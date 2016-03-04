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
using System.Collections;
using System.Collections.Generic;
using SelectAnonymous;
using SelectAnonymous.FactoryClasses;
using SelectAnonymous.HelperClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace SelectAnonymous.RelationClasses
{
	/// <summary>Implements the relations factory for the entity: Student. </summary>
	public partial class StudentRelations
	{
		/// <summary>CTor</summary>
		public StudentRelations()
		{
		}

		/// <summary>Gets all relations of the StudentEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			return toReturn;
		}

		#region Class Property Declarations



		/// <summary>stub, not used in this entity, only for TargetPerEntity entities.</summary>
		public virtual IEntityRelation GetSubTypeRelation(string subTypeEntityName) { return null; }
		/// <summary>stub, not used in this entity, only for TargetPerEntity entities.</summary>
		public virtual IEntityRelation GetSuperTypeRelation() { return null;}
		#endregion

		#region Included Code

		#endregion
	}
	
	/// <summary>Static class which is used for providing relationship instances which are re-used internally for syncing</summary>
	internal static class StaticStudentRelations
	{

		/// <summary>CTor</summary>
		static StaticStudentRelations()
		{
		}
	}
}
