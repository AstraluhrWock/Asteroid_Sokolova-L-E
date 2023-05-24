using UnityEngine;

namespace Asteroids.Prototype
{
    internal sealed  class MainPrototype : MonoBehaviour
    {
        private void Start()
        {
            EnemyData enemyData = new EnemyData
            {
                hp = new EnemyHP
                {
                    CurrentHP = 100,
                    MaxHP = 100
                },
                Speed = 10
            };
            EnemyData enemyDataNew = enemyData.DeepCopy();
            enemyDataNew.hp.CurrentHP = 200;
            Debug.Log(enemyData);
            Debug.Log(enemyDataNew);
        }
    }
}
