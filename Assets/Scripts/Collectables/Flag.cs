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
    [AddComponentMenu("Collectables/Flag")]
    public class Flag : MonoBehaviour
    {
        #region Properties and Fields

        public string team = "";

        private Vector3 initialPosition;

        #endregion

        #region Unity Methods

        private void Start()
        {
            initialPosition = transform.localPosition;
        }

        #endregion

        #region Flag State Methods

        public void Reset()
        {
            transform.localPosition = initialPosition;
        }

        #endregion

        #region Collision Callbacks

        void OnTriggerEnter(Collider other)
        {
            Player player = other.GetComponent<Player>();
            if (player != null)
            {
                if (player.team == team)
                {
                    Reset();
                }
                else
                {
                    Destroy(gameObject);
                }
            }
        }

        #endregion
    }
}
