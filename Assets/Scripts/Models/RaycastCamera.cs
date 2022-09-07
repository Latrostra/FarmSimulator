using ScriptableObjectArchitecture;
using UnityEngine;
using UnityEngine.InputSystem;

public class RaycastCamera : MonoBehaviour
{
    [SerializeField] private RaycastCameraVariable raycastCameraVariable;
    private Camera cam;

    private void Awake()
    {
        raycastCameraVariable.Value = this;
        cam = Camera.main;
    }

    public RaycastHit2D GetRaycastHit(Vector2 position, float distance, LayerMask layerMask)
    {
        return Physics2D.Raycast(position, GetMousePosition(), distance, layerMask);
    }
    
    public RaycastHit2D GetRaycastHit(Vector2 position, LayerMask layerMask)
    {
        return Physics2D.Raycast(position, Vector2.zero, 2f, layerMask);
    }

    public Interactable GetInteractable(RaycastHit2D hit)
    {
        var hitCollider = hit.collider;
        return !hit.collider ? null : hitCollider.GetComponent<Interactable>();
    }

    private Vector2 GetMousePosition()
    {
        return cam.ScreenToWorldPoint(Mouse.current.position.ReadValue());
    }
}
