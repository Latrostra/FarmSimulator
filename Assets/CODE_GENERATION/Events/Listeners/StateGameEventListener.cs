using ScriptableObjects.States;
using UnityEngine;

namespace ScriptableObjectArchitecture
{
	[AddComponentMenu(SOArchitecture_Utility.EVENT_LISTENER_SUBMENU + "State")]
	public sealed class StateGameEventListener : BaseGameEventListener<State, StateGameEvent, StateUnityEvent>
	{
	}
}