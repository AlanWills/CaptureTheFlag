using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEditor;

namespace Collectables
{
    public class FlagEditor : Editor
    {
        [MenuItem("Assets/Create/Flag")]
        public static void CreateAsset()
        {
            ScriptableObjectUtility.CreateAsset<Flag>();
        }
    }
}
