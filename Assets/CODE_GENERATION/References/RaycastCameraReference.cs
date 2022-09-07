using UnityEngine;

namespace ScriptableObjectArchitecture
{
	[System.Serializable]
	public sealed class RaycastCameraReference : BaseReference<RaycastCamera, RaycastCameraVariable>
	{
	    public RaycastCameraReference() : base() { }
	    public RaycastCameraReference(RaycastCamera value) : base(value) { }
	}
}