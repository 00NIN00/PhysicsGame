using UnityEngine;

namespace _Game.Scripts
{
    public class Timer
    {
        private float _time;
        public float _currentTime { get; private set; }

        public bool _isDone { get; private set; } = false;

        public Timer(float maxTime)
        {
            _time = maxTime;
            Reset();
        }
        
        public void Reset()
        {
            _currentTime = _time;
            _isDone = false;
        }
        
        public void Update()
        {
            if (_currentTime > 0)
                _currentTime -= Time.deltaTime;
            else
                _isDone = true;
        }
    }
}