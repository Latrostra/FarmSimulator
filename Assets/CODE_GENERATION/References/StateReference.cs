using ScriptableObjects.States;
using UnityEngine;

namespace ScriptableObjectArchitecture
{
	[System.Serializable]
	public sealed class StateReference : BaseReference<State, StateVariable>
	{
	    public StateReference() : base() { }
	    public StateReference(State value) : base(value) { }
	}
}