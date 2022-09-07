using ScriptableObjects.Models;
using UnityEngine;

namespace ScriptableObjectArchitecture
{
	[System.Serializable]
	public sealed class DayReference : BaseReference<Day, DayVariable>
	{
	    public DayReference() : base() { }
	    public DayReference(Day value) : base(value) { }
	}
}