using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Assessment1
{
    public class CameraFollow : MonoBehaviour
    {

        public Transform target;
        public float smoothSpeed = .3f;

        private Vector3 currentVolcity;

        void LateUpdate()
        {
            if(target.position.y > transform.position.y)
            {
                Vector3 newPos = new Vector3(0f, target.position.y, -10f); // Moves the camera with the targeted object's posiition (currently in Y)
                transform.position = Vector3.SmoothDamp(transform.position, newPos, ref currentVolcity, smoothSpeed * Time.deltaTime); // Allows the camera to move smoothly
            }
        }
    }
}