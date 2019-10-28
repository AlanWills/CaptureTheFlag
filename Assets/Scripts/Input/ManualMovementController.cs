using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Input
{
    [AddComponentMenu("Input/Manual Movement Controller")]
    public class ManualMovementController : MonoBehaviour
    {
        #region Properties and Fields

        public const string SIDEWAYS_AXIS = "Horizontal";
        public const string FORWARD_AXIS = "Vertical";

        public float speed = 1;

        #endregion

        #region Unity Methods

        void Update()
        {
            float sidewaysMovement = UnityEngine.Input.GetAxis(SIDEWAYS_AXIS) * Time.deltaTime;
            float forwardMovement = UnityEngine.Input.GetAxis(FORWARD_AXIS) * Time.deltaTime;

            if (sidewaysMovement != 0 || forwardMovement != 0)
            {
                transform.Translate(sidewaysMovement * speed, 0, forwardMovement * speed);
            }
        }

        #endregion
    }
}