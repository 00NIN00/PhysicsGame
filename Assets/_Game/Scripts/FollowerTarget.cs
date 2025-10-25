using UnityEngine;

namespace _Game.Scripts
{
    public class FollowerTarget : MonoBehaviour
    {
        [SerializeField] private Transform _target;
        
        [SerializeField] private Vector3 _offset;
        
        private void LateUpdate()
        {
            Move();
        }

        private void Move()
        {
            transform.position = _target.position + _offset;
        }
    }
}