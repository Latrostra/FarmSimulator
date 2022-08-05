using UnityEngine;
using UnityEngine.Events;
using System;

namespace ScriptableObjectArchitecture
{
	[System.Serializable]
	public class TypeEvent : UnityEvent<Type> { }

	[CreateAssetMenu(
	    fileName = "TypeVariable.asset",
	    menuName = SOArchitecture_Utility.VARIABLE_SUBMENU + "Type",
	    order = 120)]
	public class TypeVariable : BaseVariable<Type, TypeEvent>
	{
	}
}