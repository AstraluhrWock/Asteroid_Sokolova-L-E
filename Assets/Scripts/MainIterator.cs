using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using Asteroids.Interfaces;

namespace Asteroids.Iterator
{
    internal sealed class MainIterator : MonoBehaviour
    {
        private void Start()
        {
            List<IAbility> ability = new List<IAbility>
            {
                new Ability("Projectile", 100, Target.None, DamageType.Projectile),
                new Ability("Explosion", 200, Target.Unit | Target.Autocast, DamageType.Collision),
                new Ability("Speed Down", 400, Target.Passive, DamageType.StatusEffect)
            };

            IEnemy enemy = new EnemyIterator(ability);

            Debug.Log(enemy[0]);
            Debug.Log(new string('-', 25));
            Debug.Log(enemy[Target.Unit | Target.Autocast]);
            Debug.Log(new string('-', 25));
            Debug.Log(enemy[Target.Unit | Target.Passive]);
            Debug.Log(new string('-', 25));
            Debug.Log(enemy.MaxDamage);
            Debug.Log(new string('-', 25));

            foreach (var e in enemy)
            {
                Debug.Log(e);
            }
            Debug.Log(new string('-', 25));
            foreach (var e in enemy.GetAbility().Take(2))
            {
                Debug.Log(e);
            }
            Debug.Log(new string('-', 25));
            foreach (var e in enemy.GetAbility(DamageType.Projectile))
            {
                Debug.Log(e);
            }
        }
    }
}

