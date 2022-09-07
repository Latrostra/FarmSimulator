using ScriptableObjects.Models;
using UnityEngine;

namespace ScriptableObjectArchitecture
{
	[CreateAssetMenu(
	    fileName = "MonthCollection.asset",
	    menuName = SOArchitecture_Utility.COLLECTION_SUBMENU + "Month",
	    order = 120)]
	public class MonthCollection : Collection<Month>
	{
	}
}