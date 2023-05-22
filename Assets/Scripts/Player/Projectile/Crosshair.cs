using UnityEngine;

namespace Asteroids
{
   public class Crosshair : MonoBehaviour
    {
        [SerializeField] private Rigidbody2D _rigirbody;
        [SerializeField] private float _force;
        [SerializeField] private Transform _transform;
        private Player _player;


        public Rigidbody2D CrosshairRigidbody
        {
            get { return _rigirbody; }
            set { _rigirbody = value; }
        }

        public Transform CrosshairTransform
        {
            get { return _player.PlayerTransform; }
            set { _transform = _player.PlayerTransform; }
        }

        public void CreateCrosshair()
        {
            Crosshair _cross = Resources.Load<Crosshair>("Crosshair");
            Instantiate(_cross, _cross.CrosshairTransform.position, Quaternion.identity);
            _cross.CrosshairRigidbody.AddForce(_cross.transform.up * _force);
        }
    }
}
