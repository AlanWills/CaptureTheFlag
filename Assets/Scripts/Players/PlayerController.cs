using Collectables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Players
{
    [AddComponentMenu("Players/Player Controller")]
    public class PlayerController : MonoBehaviour
    {
        #region Properties and Fields

        public Player player;

        private GameObject flag;

        #endregion

        #region Flag Functions

        public void PickupFlag(GameObject gameObject)
        {
            flag = gameObject;

            gameObject.transform.SetParent(transform);
            gameObject.transform.localPosition = Vector3.zero;
        }

        public void DropFlag()
        {
            flag = null;
        }

        #endregion
    }
}
