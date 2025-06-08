using UnityEngine;

namespace Camera
{
    public class HeadBob : MonoBehaviour
    {
        public float bobSpeed = 8f;
        public float bobAmount = 0.05f;

        private Vector3 _originalPos;
        private float _timer;

        void Start()
        {
            _originalPos = transform.localPosition;
        }

        public void OnMove(float magnitude)
        {
            if (magnitude > 0.1f)
            {
                _timer += Time.deltaTime * bobSpeed;
                transform.localPosition = _originalPos + new Vector3(0, Mathf.Sin(_timer) * bobAmount, 0);
            }
            else
            {
                _timer = 0f;
                transform.localPosition = Vector3.Lerp(transform.localPosition, _originalPos, Time.deltaTime * 5f);
            }
        }
    }
}
