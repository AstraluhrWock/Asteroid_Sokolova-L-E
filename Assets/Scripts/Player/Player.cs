using Asteroids.Interfaces;
using UnityEngine;

namespace Asteroids
{
    internal sealed class Player : MonoBehaviour
    {
        [SerializeField] private float _speed;
        [SerializeField] private float _acceleration;
        [SerializeField] private float _health;

        private readonly IAttack _attack;

        private Camera _camera;
        private Ship _ship;
        private Bullet _bullet;
        private Transform _transform;

        public Transform PlayerTransform
        {
            get { return _transform; }
            set { _transform = value; }
        }

        public Player(IAttack attack)
        {
            _attack = attack;
        }

        public void Attack()
        {
            _attack.Attack();
        }

        private void Start()
        {
            _camera = Camera.main;
            var moveTransform = new AccelerationMove(transform, _speed, _acceleration);
            var rotation = new RotationShip(transform);
            _ship = new Ship(moveTransform, rotation);
            //_bullet = new Bullet();
         
        }
        private void Update()
        {
            var direction = Input.mousePosition - _camera.WorldToScreenPoint(transform.position);
            _ship.Rotation(direction);
            _ship.Move(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), Time.deltaTime);

            if (Input.GetKeyDown(KeyCode.LeftShift))
            {
                _ship.AddAcceleration();
                Debug.Log("Add Acceleration");
            }

            if (Input.GetKeyUp(KeyCode.LeftShift))
            {
                _ship.RemoveAcceleration();
                Debug.Log("Remove Acceleration");
            }

           /* if (Input.GetButtonDown("Fire1"))
            {
                _bullet.CreateBullet();
                Debug.Log("Creat bullet");
            }*/

        }
        private void OnCollisionEnter2D(Collision2D other)
        {
            if (_health <= 0)
            {
                Destroy(gameObject);
            }
            else
            {
                _health--;
            }
        }
    }
}