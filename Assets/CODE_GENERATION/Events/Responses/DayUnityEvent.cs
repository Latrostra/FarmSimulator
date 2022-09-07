using ScriptableObjects.Models;
using UnityEngine;
using UnityEngine.Events;

namespace ScriptableObjectArchitecture
{
	[System.Serializable]
	public sealed class DayUnityEvent : UnityEvent<Day>
	{
	}
}