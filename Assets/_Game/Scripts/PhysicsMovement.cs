using UnityEngine;

namespace _Game.Scripts
{
    public class PhysicsMovement
    {
        private Rigidbody _rigidbody;
        private float _force;

        public PhysicsMovement(Rigidbody rigidbody, float force)
        {
            _rigidbody = rigidbody;
            _force = force;
        }
        
        public void MoveTo(Vector3 direction)
        {
            _rigidbody.AddForce(direction * _force);
        }
    }
}