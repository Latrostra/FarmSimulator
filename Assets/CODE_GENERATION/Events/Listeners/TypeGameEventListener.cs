using UnityEngine;
using System;

namespace ScriptableObjectArchitecture
{
	[AddComponentMenu(SOArchitecture_Utility.EVENT_LISTENER_SUBMENU + "Type")]
	public sealed class TypeGameEventListener : BaseGameEventListener<Type, TypeGameEvent, TypeUnityEvent>
	{
	}
}