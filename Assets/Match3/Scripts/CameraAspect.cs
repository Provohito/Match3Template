using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Match3
{
    [ExecuteAlways]
    public class CameraAspect : MonoBehaviour
    {
        [SerializeField]
        float width;

        Camera targetCamera;

        void Awake()
        {
            targetCamera = GetComponent<Camera>();
        }
        // Update is called once per frame
        void Update()
        {
            targetCamera.orthographicSize = (float)Screen.height / Screen.width * width;
        }
    }
}
