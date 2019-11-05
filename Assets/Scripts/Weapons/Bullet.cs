using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Weapons
{
    public class Bullet : ScriptableObject
    {
        #region Properties and Fields

        public GameObject bulletPrefab;
        public float speed = 1;
        public float lifeTime = 2;
        public float damage = 1;

        #endregion
    }
}
