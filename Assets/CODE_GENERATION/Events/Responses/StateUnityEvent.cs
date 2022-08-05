using ScriptableObjects.States;
using UnityEngine;
using UnityEngine.Events;

namespace ScriptableObjectArchitecture
{
	[System.Serializable]
	public sealed class StateUnityEvent : UnityEvent<State>
	{
	}
}