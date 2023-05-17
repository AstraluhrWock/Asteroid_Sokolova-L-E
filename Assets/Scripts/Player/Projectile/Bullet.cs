using UnityEngine;

namespace Asteroids
{
    public class Bullet : MonoBehaviour
    {
        [SerializeField] private Rigidbody2D _rigirbody;
        //[SerializeField] private Transform _barrel;
        [SerializeField] private float _force;
        [SerializeField] private Transform _transform;
        private Player _player;
       

        public Rigidbody2D Rigidbody
        {
            get { return _rigirbody; }
            set { _rigirbody = value; }
        }

        public Transform BulletTransform
        {
            get { return _player.PlayerTransform; }
            set { _transform = _player.PlayerTransform; }
        }

        public void CreateBullet()
        {
            Bullet _bullet = Resources.Load<Bullet>("Missile");
            Instantiate(_bullet, _bullet.BulletTransform.position, Quaternion.identity);
            _bullet.Rigidbody.AddForce(_bullet.transform.up * _force);
        }
    }
}
