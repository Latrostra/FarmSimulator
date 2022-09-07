using ScriptableObjects.Items;
using UnityEngine;

namespace ScriptableObjectArchitecture
{
	[CreateAssetMenu(
	    fileName = "ToolCollection.asset",
	    menuName = SOArchitecture_Utility.COLLECTION_SUBMENU + "Tool",
	    order = 120)]
	public class ToolCollection : Collection<Tool>
	{
	}
}