using ScriptableObjects.Models;
using UnityEngine;

namespace ScriptableObjectArchitecture
{
	[CreateAssetMenu(
	    fileName = "DayCollection.asset",
	    menuName = SOArchitecture_Utility.COLLECTION_SUBMENU + "Day",
	    order = 120)]
	public class DayCollection : Collection<Day>
	{
	}
}