using UnityEngine;

namespace _Game.Scripts
{
    public class PickupObject : MonoBehaviour
    {
        [SerializeField] private int _value;
        
        public int Value => _value;

        public void PickUp()
        {
            gameObject.SetActive(false);
        }
    }
}