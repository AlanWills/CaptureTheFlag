using Players;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Collectables
{
    public enum FlagState
    {
        AtBase,
        Dropped,
        Carried
    }

    public class Flag : ScriptableObject
    {
        #region Properties and Fields

        public string team = "";
        
        private FlagState flagState = FlagState.AtBase;

        #endregion

        #region Flag Functions

        public void Reset()
        {
            flagState = FlagState.AtBase;
        }

        public void GetCarried()
        {
            flagState = FlagState.Carried;
        }

        #endregion
    }
}
