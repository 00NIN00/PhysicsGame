using UnityEngine;

namespace _Game.Scripts
{
    [RequireComponent(typeof(Rigidbody))]
    [RequireComponent(typeof(GroundChecker))]
    public class Character : MonoBehaviour
    {
        private Vector3 _input;
        private bool _jumpInput;

        private PhysicsMovement _physicsMovement;
        private PhysicsJump _physicsJump;
        private GroundChecker _groundChecker;

        [SerializeField] private float _force;
        [SerializeField] private float _forceJump;

        private void Awake()
        {
            Rigidbody rigidbody = GetComponent<Rigidbody>();
            _groundChecker = GetComponent<GroundChecker>();

            _physicsMovement = new PhysicsMovement(rigidbody, _force);
            _physicsJump = new PhysicsJump(rigidbody, _forceJump);
        }

        public void SetInput(Vector3 input, bool jumpInput)
        {
            _input = input;
            _jumpInput = jumpInput;
        }

        private void FixedUpdate()
        {
            Move();
            Jump();
        }

        private void Jump()
        {
            if (_jumpInput && _groundChecker.IsGrounded())
            {
                _physicsJump.Jump();

                _jumpInput = false;
            }
        }

        private void Move()
        {
            _physicsMovement.MoveTo(_input);
        }
    }
}