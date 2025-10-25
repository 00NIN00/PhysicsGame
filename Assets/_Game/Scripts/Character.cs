using UnityEngine;

namespace _Game.Scripts
{
    [RequireComponent(typeof(Rigidbody))]
    public class Character : MonoBehaviour
    {
        private Vector3 _input;

        private PhysicsMovement _physicsMovement;

        [SerializeField] private float _force;

        private void Awake()
        {
            Rigidbody rigidbody = GetComponent<Rigidbody>();

            _physicsMovement = new PhysicsMovement(rigidbody, _force);
        }

        public void SetInput(Vector3 input)
        {
            _input = input;
        }

        private void FixedUpdate()
        {
            Move();
        }

        private void Move()
        {
            _physicsMovement.MoveTo(_input);
        }
    }
}