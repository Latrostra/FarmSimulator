using ScriptableObjects.Models;
using UnityEngine;

namespace ScriptableObjectArchitecture
{
	[System.Serializable]
	[CreateAssetMenu(
	    fileName = "DayGameEvent.asset",
	    menuName = SOArchitecture_Utility.GAME_EVENT + "Day",
	    order = 120)]
	public sealed class DayGameEvent : GameEventBase<Day>
	{
	}
}