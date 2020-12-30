using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MichMond.Cinema.Modifier
{
    public class CameraModifier : MonoBehaviour
    {
        public CameraModifierType type;
    }

    public enum CameraModifierType
    {
        DollyZoom
    }
}
