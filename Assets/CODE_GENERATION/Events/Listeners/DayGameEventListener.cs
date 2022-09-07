using ScriptableObjects.Models;
using UnityEngine;

namespace ScriptableObjectArchitecture
{
	[AddComponentMenu(SOArchitecture_Utility.EVENT_LISTENER_SUBMENU + "Day")]
	public sealed class DayGameEventListener : BaseGameEventListener<Day, DayGameEvent, DayUnityEvent>
	{
	}
}