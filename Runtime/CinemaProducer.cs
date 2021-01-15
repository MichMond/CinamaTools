using UnityEngine;
using UnityEditor;

public class CinemaProducer : MonoBehaviour
{
    [SerializeField] private CameraControlMethod cameraControlMethod = CameraControlMethod.Single;

    private Transform tr;
    private Camera[] cameras;

    private float camFieldOfView
    {
        set
        {
            if (cameraControlMethod == CameraControlMethod.Single)
            {
                cameras[0].fieldOfView = value;
            }
            else
            {
                for (int i = 0; i < cameras.Length; i++)
                {
                    if (cameras[i])
                        cameras[i].fieldOfView = value;
#if UNITY_EDITOR
                    else
                        Debug.LogError($"Cinema Tools -> Cinema Producer Cam {i} == NULL");
#endif
                }
            }
        }
    }

    public enum CameraControlMethod { Single, Legasy }
}
