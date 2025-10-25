using UnityEngine;

namespace _Game.Scripts
{
    public class PhysicsMovement : PhysicsApplication
    {
        public PhysicsMovement(Rigidbody rigidbody, float force) : base(rigidbody, force)
        {
        }
        
        public void MoveTo(Vector3 direction)
        {
            _rigidbody.AddForce(direction * _force);
        }
    }
}