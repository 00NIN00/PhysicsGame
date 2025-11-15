using UnityEngine;

namespace _Game.Scripts
{
    public class Wallet : MonoBehaviour
    {
        private int _value;

        public int Value => _value;

        public void Add(int value)
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