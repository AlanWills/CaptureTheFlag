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
        public GameObject bullet;

        #endregion

        #region Unity Methods

        private void Update()
        {
            if (UnityEngine.Input.GetKeyDown(KeyCode.Space))
            {
                GameObject bulletInstance = Instantiate(bullet);
                bulletInstance.transform.localPosition = gunEnd.position;
                bulletInstance.transform.localRotation = gunEnd.rotation;
                bulletInstance.GetComponent<Rigidbody>().velocity = gunEnd.forward;
            }
        }

        #endregion
    }
}
