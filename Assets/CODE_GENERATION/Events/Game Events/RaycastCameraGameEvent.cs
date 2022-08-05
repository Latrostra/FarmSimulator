using UnityEngine;

namespace ScriptableObjectArchitecture
{
	[System.Serializable]
	[CreateAssetMenu(
	    fileName = "RaycastCameraGameEvent.asset",
	    menuName = SOArchitecture_Utility.GAME_EVENT + "RaycastCamera",
	    order = 120)]
	public sealed class RaycastCameraGameEvent : GameEventBase<RaycastCamera>
	{
	}
}