using ScriptableObjects.Models;
using UnityEngine;
using UnityEngine.Events;

namespace ScriptableObjectArchitecture
{
	[System.Serializable]
	public class DayEvent : UnityEvent<Day> { }

	[CreateAssetMenu(
	    fileName = "DayVariable.asset",
	    menuName = SOArchitecture_Utility.VARIABLE_SUBMENU + "Day",
	    order = 120)]
	public class DayVariable : BaseVariable<Day, DayEvent>
	{
	}
}