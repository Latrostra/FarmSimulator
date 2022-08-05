using ScriptableObjects.States;
using UnityEngine;

namespace ScriptableObjectArchitecture
{
	[System.Serializable]
	[CreateAssetMenu(
	    fileName = "StateGameEvent.asset",
	    menuName = SOArchitecture_Utility.GAME_EVENT + "State",
	    order = 120)]
	public sealed class StateGameEvent : GameEventBase<State>
	{
	}
}