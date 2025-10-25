using UnityEngine;

namespace _Game.Scripts
{
    public class PhysicsJump : PhysicsApplication
    {
        public PhysicsJump(Rigidbody rigidbody, float force) : base(rigidbody, force)
        {
        }

        public void Jump()
        {
            _rigidbody.AddForce(Vector3.up * _force, ForceMode.Impulse);
        }
    }
}