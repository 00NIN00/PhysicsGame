using UnityEngine;

namespace _Game.Scripts
{
    public class Wallet : MonoBehaviour
    {
        private int _value;

        public int Value => _value;
        
        private void Update()
        {
            if (EventInterlayer.Instance.TryGet(out int value))
            {
                Add(value);
            }
        }

        private void Add(int value)
        {
            if (value > 0)
            {
                _value += value;
            }
        }
    }
}