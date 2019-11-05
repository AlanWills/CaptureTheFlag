using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEditor;

namespace Weapons
{
    public class WeaponEditor : Editor
    {
        #region Create Menu Item

        [MenuItem("Assets/Create/Weapon")]
        public static void CreateAsset()
        {
            ScriptableObjectUtility.CreateAsset<Weapon>();
        }

        #endregion
    }
}
