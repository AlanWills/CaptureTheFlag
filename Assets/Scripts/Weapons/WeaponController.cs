using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Weapons
{
    [AddComponentMenu("Weapons/WeaponController")]
    public class WeaponController : MonoBehaviour
    {
        #region Properties and Fields

        public Transform gunEnd;
        public Weapon weapon;

        #endregion

        #region Unity Methods

        private void Update()
        {
            if (UnityEngine.Input.GetKeyDown(KeyCode.Space))
            {
                GameObject bulletInstance = Instantiate(weapon.bullet.bulletPrefab);
                bulletInstance.transform.localPosition = gunEnd.position;
                bulletInstance.transform.localRotation = gunEnd.rotation;
                bulletInstance.GetComponent<Rigidbody>().velocity = gunEnd.forward * weapon.bullet.speed;
                bulletInstance.GetComponent<BulletController>().Activate(weapon.bullet);
            }
        }

        #endregion
    }
}
