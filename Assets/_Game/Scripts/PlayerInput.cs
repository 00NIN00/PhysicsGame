using UnityEngine;

namespace _Game.Scripts
{
    [RequireComponent(typeof(Character))]
    public class PlayerInput : MonoBehaviour
    {
        private const string HorizontalAxisName = "Horizontal";
        private const string VerticalAxisName = "Vertical";
        private const KeyCode JumpKey = KeyCode.Space;
        
        private Character  _character;

        private void Awake()
        {
            _character = GetComponent<Character>();
        }

        private void Update()
        {
            _character.SetInput(GetInput(), GetKeyJumpInput());
        }

        private Vector3 GetInput()
        {
            return new Vector3(Input.GetAxisRaw(HorizontalAxisName), 0, Input.GetAxisRaw(VerticalAxisName));
        }

        private bool GetKeyJumpInput()
        {
            return Input.GetKey(JumpKey);
        }
    }
}