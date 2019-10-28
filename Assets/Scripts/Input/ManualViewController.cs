﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Input
{
    public enum RotationAxes 
    { 
        MouseX, 
        MouseY
    }

    [AddComponentMenu("Input/Manual View Controller")]
    public class ManualViewController : MonoBehaviour
    {
        #region Properties and Fields

        public const string HORIZONTAL_AXIS = "Mouse X";
        public const string VERTICAL_AXIS = "Mouse Y";

        public RotationAxes axes = RotationAxes.MouseX;
        public float speed = 1;

        #endregion

        #region Unity Methods

        void Update()
        {
            float horizontalMovement = UnityEngine.Input.GetAxis(HORIZONTAL_AXIS) * Time.deltaTime;
            float verticalMovement = UnityEngine.Input.GetAxis(VERTICAL_AXIS) * Time.deltaTime;

            if (axes.HasFlag(RotationAxes.MouseX) && horizontalMovement != 0)
            {
                transform.localRotation *= Quaternion.AngleAxis(horizontalMovement * speed, Vector3.up);
            }

            if (axes.HasFlag(RotationAxes.MouseY) && verticalMovement != 0)
            {
                Debug.Log(verticalMovement);
                transform.localRotation *= Quaternion.AngleAxis(verticalMovement * speed, Vector3.right);
            }
        }

        #endregion
    }
}