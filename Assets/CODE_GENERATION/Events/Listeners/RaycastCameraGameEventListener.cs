using UnityEngine;

namespace ScriptableObjectArchitecture
{
	[AddComponentMenu(SOArchitecture_Utility.EVENT_LISTENER_SUBMENU + "RaycastCamera")]
	public sealed class RaycastCameraGameEventListener : BaseGameEventListener<RaycastCamera, RaycastCameraGameEvent, RaycastCameraUnityEvent>
	{
	}
}