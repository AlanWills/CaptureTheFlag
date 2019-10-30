using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEditor;

namespace Players
{
    public class PlayerEditor : Editor
    {
        [MenuItem("Assets/Create/Player")]
        public static void CreateAsset()
        {
            ScriptableObjectUtility.CreateAsset<Player>();
        }
    }
}
