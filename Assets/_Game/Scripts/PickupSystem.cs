using System.Collections.Generic;
using UnityEngine;

namespace _Game.Scripts
{
    public class PickupSystem : MonoBehaviour
    {
        private Queue<int> _moneys =  new Queue<int>();

        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.TryGetComponent(out PickupObject pickupObject))
            {
                _moneys.Enqueue(pickupObject.Value);
                pickupObject.PickUp();
            }
        }
        
        public bool TryGet(out int value)
        {
            value = 0;

            if (_moneys.Count <= 0) return false;
            
            value = _moneys.Dequeue();
            return true;
        }
    }
}