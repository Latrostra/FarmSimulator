using ScriptableObjects.Models;
using UnityEngine;

namespace ScriptableObjectArchitecture
{
	[System.Serializable]
	public sealed class MonthReference : BaseReference<Month, MonthVariable>
	{
	    public MonthReference() : base() { }
	    public MonthReference(Month value) : base(value) { }
	}
}