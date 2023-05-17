using UnityEngine;

namespace Asteroids
{
    internal class InputSystem
    {
        private Ship _ship;
        private Bullet _bulletSystem;

        public void InputSystemSet()
        {

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

            /*if (Input.GetButtonDown("Fire1"))
            {
                _bulletSystem.CreateBullet();
                Debug.Log("Creat bullet");
            }*/
        }
    }
}

