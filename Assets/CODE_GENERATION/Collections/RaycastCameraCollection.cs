using UnityEngine;

namespace ScriptableObjectArchitecture
{
	[CreateAssetMenu(
	    fileName = "RaycastCameraCollection.asset",
	    menuName = SOArchitecture_Utility.COLLECTION_SUBMENU + "RaycastCamera",
	    order = 120)]
	public class RaycastCameraCollection : Collection<RaycastCamera>
	{
	}
}