using ScriptableObjects.Models;
using UnityEngine;

namespace ScriptableObjectArchitecture
{
	[AddComponentMenu(SOArchitecture_Utility.EVENT_LISTENER_SUBMENU + "Month")]
	public sealed class MonthGameEventListener : BaseGameEventListener<Month, MonthGameEvent, MonthUnityEvent>
	{
	}
}