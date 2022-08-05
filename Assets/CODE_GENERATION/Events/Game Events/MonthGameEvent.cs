using ScriptableObjects.Models;
using UnityEngine;

namespace ScriptableObjectArchitecture
{
	[System.Serializable]
	[CreateAssetMenu(
	    fileName = "MonthGameEvent.asset",
	    menuName = SOArchitecture_Utility.GAME_EVENT + "Month",
	    order = 120)]
	public sealed class MonthGameEvent : GameEventBase<Month>
	{
	}
}