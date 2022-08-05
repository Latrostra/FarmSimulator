using System;
using UnityEngine;

namespace Models
{
    public class Action : MonoBehaviour
    {
        private static Actions _actions;
        private void Awake()
        {
            _actions = new Actions();
        }

        private void Start()
        {
            _actions.Player.Enable();
        }

        public static Actions.PlayerActions GetPlayerActions()
        {
            return _actions.Player;
        }
    }
}
