using UnityEngine;

namespace _Game.Scripts
{
    public class Wallet : MonoBehaviour
    {
        private PickupCoinsSystem _pickupCoinsSystem;
        
        private int _value;

        public int Value => _value;

        private void Awake()
        {
            _pickupCoinsSystem = GetComponent<PickupCoinsSystem>();
        }

        private void Update()
        {
            if (_pickupCoinsSystem.TryGet(out int money))
            {
                Add(money);
            }
        }

        private void Add(int value)
        {
            if (value > 0)
            {
                _value += value;
            }
        }

        public void Reset()
        {
            _value = 0;
        }
    }
}