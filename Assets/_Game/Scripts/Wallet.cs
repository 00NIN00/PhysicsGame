using UnityEngine;

namespace _Game.Scripts
{
    public class Wallet : MonoBehaviour
    {
        private int _value = 0;

        public int Value => _value;

        private void Add(int value)
        {
            if (value > 0)
            {
                _value += value;
            }
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.TryGetComponent(out PickupObject pickupObject))
            {
                Add(pickupObject.Value);
                pickupObject.PickUp();
            }
        }
    }
}