using ScriptableObjects.Items;
using UnityEngine;
using UnityEngine.Events;

namespace ScriptableObjectArchitecture
{
	[System.Serializable]
	public class ToolEvent : UnityEvent<Tool> { }

	[CreateAssetMenu(
	    fileName = "ToolVariable.asset",
	    menuName = SOArchitecture_Utility.VARIABLE_SUBMENU + "Tool",
	    order = 120)]
	public class ToolVariable : BaseVariable<Tool, ToolEvent>
	{
	}
}