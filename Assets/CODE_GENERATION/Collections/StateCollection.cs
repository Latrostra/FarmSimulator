using ScriptableObjects.States;
using UnityEngine;

namespace ScriptableObjectArchitecture
{
	[CreateAssetMenu(
	    fileName = "StateCollection.asset",
	    menuName = SOArchitecture_Utility.COLLECTION_SUBMENU + "State",
	    order = 120)]
	public class StateCollection : Collection<State>
	{
	}
}