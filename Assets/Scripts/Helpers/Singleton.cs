using UnityEngine;

namespace Helpers
{
    public class Singleton<T> : MonoBehaviour where T : MonoBehaviour
    {
        public static T Instance { get; private set; }

        private void Awake()
        {
            Instance = (T)(object)this;
        }
    }
}
