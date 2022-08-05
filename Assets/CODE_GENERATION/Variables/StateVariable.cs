using ScriptableObjects.States;
using UnityEngine;
using UnityEngine.Events;

namespace ScriptableObjectArchitecture
{
	[System.Serializable]
	public class StateEvent : UnityEvent<State> { }

	[CreateAssetMenu(
	    fileName = "StateVariable.asset",
	    menuName = SOArchitecture_Utility.VARIABLE_SUBMENU + "State",
	    order = 120)]
	public class StateVariable : BaseVariable<State, StateEvent>
	{
	}
}