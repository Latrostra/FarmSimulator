using UnityEngine;
using UnityEngine.Events;

namespace ScriptableObjectArchitecture
{
	[System.Serializable]
	public class DateTimeEvent : UnityEvent<DateTime> { }

	[CreateAssetMenu(
	    fileName = "DateTimeVariable.asset",
	    menuName = SOArchitecture_Utility.VARIABLE_SUBMENU + "DateTime",
	    order = 120)]
	public class DateTimeVariable : BaseVariable<DateTime, DateTimeEvent>
	{
	}
}