using UnityEngine;

namespace _Game.Scripts
{
    public class PhysicsApplication
    {
        protected Rigidbody _rigidbody;
        protected float _force;

        public PhysicsApplication(Rigidbody rigidbody, float force)
        {
            _rigidbody = rigidbody;
            _force = force;
        }

        /*public void Application(Vector3 vector, ForceMode forceMode)
        {
            _rigidbody.AddForce(vector * _force, forceMode);
        }*/
    }
}