using UnityEngine;
using UnityEngine.Events;
using System;

namespace ScriptableObjectArchitecture
{
	[System.Serializable]
	public sealed class TypeUnityEvent : UnityEvent<Type>
	{
	}
}