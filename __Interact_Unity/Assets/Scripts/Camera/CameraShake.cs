using UnityEngine;

namespace Camera
{
    public class CameraShake : MonoBehaviour
    {
        public float shakeAmount = 0.02f;
        public float shakeSpeed = 1f;

        private Vector3 _initialPos;

        void Start()
        {
            _initialPos = transform.localPosition;
        }

        void Update()
        {
            float noiseX = Mathf.PerlinNoise(Time.time * shakeSpeed, 0) - 0.5f;
            float noiseY = Mathf.PerlinNoise(0, Time.time * shakeSpeed) - 0.5f;
            Vector3 shake = new Vector3(noiseX, noiseY, 0) * shakeAmount;

            transform.localPosition = Vector3.Lerp(transform.localPosition, _initialPos + shake, Time.deltaTime * 10f);
        }
    }
}
