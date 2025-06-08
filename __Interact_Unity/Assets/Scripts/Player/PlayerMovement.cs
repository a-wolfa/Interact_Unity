using Camera;
using UnityEngine;

namespace Player
{
    public class PlayerMovement : MonoBehaviour
    {
        [Header("Movement")]
        [SerializeField] private float walkSpeed = 3f;
        [SerializeField] private float runSpeed = 5f;
        [SerializeField] private KeyCode speedKey = KeyCode.LeftShift;
    
        private float _speed;
        private Vector2 _movementDirection;
    
    
        private CharacterController _controller;
    
        private HeadBob _headBob;

        private void Awake()
        {
            Init();
        }

        private void Init()
        {
            InitComponents();
        }

        private void InitComponents()
        {
            _controller = GetComponent<CharacterController>();
            _headBob = GetComponentInChildren<HeadBob>();
        }

        void Update()
        {
            HandleInput();
            HandleMovement();
        }

        private void HandleInput()
        {
            float x = Input.GetAxis("Horizontal");
            float y = Input.GetAxis("Vertical");
            _movementDirection = new Vector2(x,y);
            _speed = Input.GetKey(speedKey) ? runSpeed : walkSpeed;
        }

        void HandleMovement()
        {
            Vector3 move = transform.right * _movementDirection.x + transform.forward * _movementDirection.y;
            _controller.Move(move * (_speed * Time.deltaTime));

            _headBob.OnMove(_controller.velocity.magnitude);
        }
    }
}
