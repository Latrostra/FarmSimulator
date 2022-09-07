using UnityEngine;
using System;

namespace ScriptableObjectArchitecture
{
	[CreateAssetMenu(
	    fileName = "TypeCollection.asset",
	    menuName = SOArchitecture_Utility.COLLECTION_SUBMENU + "Type",
	    order = 120)]
	public class TypeCollection : Collection<Type>
	{
	}
}