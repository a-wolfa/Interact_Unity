using UnityEngine;

namespace Camera
{
    public class MouseLook : MonoBehaviour
    {
        public float mouseSensitivity = 100f;
        public Transform playerBody;
        private float _xRotation = 0f;

        void Start()
        {
            Cursor.lockState = CursorLockMode.Locked;
        }

        void Update()
        {
            float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
            float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

            _xRotation -= mouseY;
            _xRotation = Mathf.Clamp(_xRotation, -75f, 75f);

            transform.localRotation = Quaternion.Euler(_xRotation, 0f, 0f).normalized;
            playerBody.Rotate(Vector3.up * mouseX);
        }
    }
}
