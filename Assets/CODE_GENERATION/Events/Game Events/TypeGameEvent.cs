using UnityEngine;
using System;

namespace ScriptableObjectArchitecture
{
	[System.Serializable]
	[CreateAssetMenu(
	    fileName = "TypeGameEvent.asset",
	    menuName = SOArchitecture_Utility.GAME_EVENT + "Type",
	    order = 120)]
	public sealed class TypeGameEvent : GameEventBase<Type>
	{
	}
}