using UnityEngine;
using System;

namespace ScriptableObjectArchitecture
{
	[System.Serializable]
	public sealed class TypeReference : BaseReference<Type, TypeVariable>
	{
	    public TypeReference() : base() { }
	    public TypeReference(Type value) : base(value) { }
	}
}