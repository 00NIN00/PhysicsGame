using UnityEngine;

namespace _Game.Scripts
{
    public class EventInterlayer : MonoBehaviour
    {
        public static EventInterlayer Instance;
        
        private int _value;
        private bool _isChanged;

        private void Awake()
        {
            if (Instance == null)
                Instance = this;
        }

        public void Set(int value)
        {
            _value = value;
            _isChanged = true;
        }

        public bool TryGet(out int value)
        {
            
            if (_isChanged)
            {
                value = _value;
                _isChanged = false;
                return true;
            }
            else
            {
                value = 0;
                _isChanged = false;
                return false;
            }
        }
    }
}