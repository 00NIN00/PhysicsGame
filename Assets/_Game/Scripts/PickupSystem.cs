using UnityEngine;

namespace _Game.Scripts
{
    public class PickupSystem : MonoBehaviour
    {
        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.TryGetComponent(out PickupObject pickupObject))
            {
                EventInterlayer.Instance.Set(pickupObject.Value);
                pickupObject.PickUp();
            }
        }
    }
}