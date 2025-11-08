using UnityEngine;

namespace _Game.Scripts
{
    public class PhysicsJump
    {
        private Rigidbody _rigidbody;
        private float _force;

        public PhysicsJump(Rigidbody rigidbody, float force)
        {
            _rigidbody = rigidbody;
            _force = force;
        }

        public void Jump()
        {
            _rigidbody.AddForce(Vector3.up * _force, ForceMode.Impulse);
        }
    }
}