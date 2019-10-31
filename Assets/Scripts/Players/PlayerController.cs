﻿using Collectables;
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
        
        public bool IsCarryingFlag { get { return flag != null; } }

        public Player player;

        private FlagController flag;

        #endregion

        #region Flag Functions

        public void PickupFlag(FlagController flagController)
        {
            flag = flagController;

            flagController.gameObject.transform.SetParent(transform);
            flagController.gameObject.transform.localPosition = Vector3.zero;
        }

        public void DropFlag()
        {
            flag.gameObject.transform.SetParent(null);
            flag = null;
        }

        public void ScoreFlag()
        {
            // Deparent before resetting position
            flag.gameObject.transform.SetParent(null);
            flag.Reset();
            flag = null;
        }

        #endregion
    }
}
