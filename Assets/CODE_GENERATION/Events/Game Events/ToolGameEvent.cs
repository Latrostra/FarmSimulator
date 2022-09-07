using ScriptableObjects.Items;
using UnityEngine;

namespace ScriptableObjectArchitecture
{
	[System.Serializable]
	[CreateAssetMenu(
	    fileName = "ToolGameEvent.asset",
	    menuName = SOArchitecture_Utility.GAME_EVENT + "Tool",
	    order = 120)]
	public sealed class ToolGameEvent : GameEventBase<Tool>
	{
	}
}