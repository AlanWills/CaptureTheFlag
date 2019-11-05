using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEditor;
using Weapons;

namespace Assets.Editor.Weapons
{
    class BulletEditor
    {
        #region Create Menu Item

        [MenuItem("Assets/Create/Bullet")]
        public static void CreateAsset()
        {
            ScriptableObjectUtility.CreateAsset<Bullet>();
        }

        #endregion
    }
}
