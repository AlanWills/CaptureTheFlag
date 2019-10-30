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
    [AddComponentMenu("Collectables/Flag Controller")]
    public class FlagController : MonoBehaviour
    {
        #region Properties and Fields

        public Flag flag;

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
            flag.Reset();
        }

        public void GetCarried(PlayerController playerController)
        {
            playerController.PickupFlag(gameObject);
            flag.GetCarried();
        }

        #endregion

        #region Collision Callbacks

        void OnTriggerEnter(Collider other)
        {
            PlayerController playerController = other.GetComponent<PlayerController>();
            if (playerController != null)
            {
                if (playerController.player.team == flag.team)
                {
                    Reset();
                }
                else
                {
                    GetCarried(playerController);
                }
            }
        }

        #endregion
    }
}
