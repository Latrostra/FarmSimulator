using ScriptableObjects.Items;
using UnityEngine;

namespace ScriptableObjectArchitecture
{
	[System.Serializable]
	public sealed class ToolReference : BaseReference<Tool, ToolVariable>
	{
	    public ToolReference() : base() { }
	    public ToolReference(Tool value) : base(value) { }
	}
}