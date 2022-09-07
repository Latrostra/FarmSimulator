using UnityEngine;

namespace ScriptableObjects
{
    [CreateAssetMenu(fileName = "newAnimationType", menuName = "AnimationType", order = 54)]
    public class AnimationType : ScriptableObject
    {
        [field: SerializeField] public string Name { get; private set; }
    }
}
