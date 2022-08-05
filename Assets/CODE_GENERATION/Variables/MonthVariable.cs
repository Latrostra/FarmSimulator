using ScriptableObjects.Models;
using UnityEngine;
using UnityEngine.Events;

namespace ScriptableObjectArchitecture
{
	[System.Serializable]
	public class MonthEvent : UnityEvent<Month> { }

	[CreateAssetMenu(
	    fileName = "MonthVariable.asset",
	    menuName = SOArchitecture_Utility.VARIABLE_SUBMENU + "Month",
	    order = 120)]
	public class MonthVariable : BaseVariable<Month, MonthEvent>
	{
	}
}