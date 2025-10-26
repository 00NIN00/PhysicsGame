using System;
using UnityEngine;

namespace _Game.Scripts
{
    public class RestartGame : MonoBehaviour
    {
        private const KeyCode RestartKey = KeyCode.R;
        
        [SerializeField] private GameRules _gameRules;
        [SerializeField] private Wallet _wallet;
        [SerializeField] private Character _player;
        [SerializeField] private PickupObject[] _coins;

        private void Update()
        {
            if (Input.GetKeyDown(RestartKey))
            {
                Restart();
            }
        }

        private void Restart()
        {
            _gameRules.Restart();
            _wallet.Reset();
            
            _player.Reset();
            _player.transform.position = Vector3.zero;

            for (int i = 0; i < _coins.Length; i++)
            {
                _coins[i].gameObject.SetActive(true);
            }
        }
    }
}