using UnityEngine;
using UnityEngine.Events;

namespace ScriptableObjectArchitecture
{
	[System.Serializable]
	public class RaycastCameraEvent : UnityEvent<RaycastCamera> { }

	[CreateAssetMenu(
	    fileName = "RaycastCameraVariable.asset",
	    menuName = SOArchitecture_Utility.VARIABLE_SUBMENU + "RaycastCamera",
	    order = 120)]
	public class RaycastCameraVariable : BaseVariable<RaycastCamera, RaycastCameraEvent>
	{
	}
}