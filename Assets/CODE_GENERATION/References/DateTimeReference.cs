using UnityEngine;

namespace ScriptableObjectArchitecture
{
	[System.Serializable]
	public sealed class DateTimeReference : BaseReference<DateTime, DateTimeVariable>
	{
	    public DateTimeReference() : base() { }
	    public DateTimeReference(DateTime value) : base(value) { }
	}
}