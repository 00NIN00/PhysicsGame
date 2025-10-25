using UnityEngine;

namespace _Game.Scripts
{
    public class GroundChecker : MonoBehaviour
    {
        private bool _isGrounded;
        private void OnCollisionEnter(Collision collision)
        {
            if (CheckTag(collision))
                _isGrounded = true;
        }

        private void OnCollisionExit(Collision collision)
        {
            if (CheckTag(collision))
                _isGrounded = false;
        }

        private bool CheckTag(Collision collision)
        {
            return collision.gameObject.GetComponent<GroundTag>() != null;
        }

        public bool IsGrounded() => _isGrounded;
    }
}