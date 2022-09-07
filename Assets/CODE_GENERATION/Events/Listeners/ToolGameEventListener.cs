using ScriptableObjects.Items;
using UnityEngine;

namespace ScriptableObjectArchitecture
{
	[AddComponentMenu(SOArchitecture_Utility.EVENT_LISTENER_SUBMENU + "Tool")]
	public sealed class ToolGameEventListener : BaseGameEventListener<Tool, ToolGameEvent, ToolUnityEvent>
	{
	}
}