using UnityEngine;

namespace _Game.Scripts
{
    public class PickupCoinsSystem : MonoBehaviour
    {
        [SerializeField] private Wallet _wallet;

        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.TryGetComponent(out PickupCoin pickupObject))
            {
                _wallet.Add(pickupObject.Value);
                pickupObject.PickUp();
            }
        }
    }
}