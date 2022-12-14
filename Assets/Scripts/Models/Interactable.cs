using UnityEngine;
using UnityEngine.Events;

public class Interactable : MonoBehaviour
{
    [SerializeField]
    private UnityEvent onInteract;

    public void OnInteract()
    {
        onInteract.Invoke();
    }
}
