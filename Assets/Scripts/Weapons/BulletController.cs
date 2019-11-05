using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Weapons
{
    [AddComponentMenu("Weapons/Bullet Controller")]
    public class BulletController : MonoBehaviour
    {
        #region Properties and Fields

        public float BulletDamage { get { return bullet.damage; } }

        private Bullet bullet;
        private float currentLifeTime = 0;

        #endregion

        #region Activation Methods

        public void Activate(Bullet bullet)
        {
            this.bullet = bullet;
        }

        #endregion

        #region Unity Methods

        private void Update()
        {
            if (bullet != null)
            {
                currentLifeTime += Time.deltaTime;

                if (currentLifeTime >= bullet.lifeTime)
                {
                    Destroy(gameObject);
                }
            }
        }

        #endregion
    }
}
