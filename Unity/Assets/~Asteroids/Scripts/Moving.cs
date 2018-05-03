using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Clean Code: CTRL + K + D (in that order)

// {} - Braces
// [] - Brackets
// () - Parentesis

namespace Asteroids
{
    public class Moving : MonoBehaviour
    {
        public float rotationSpeed = 360;
        public float movementSpeed = 2;
        public float movementSpeedback = 2;

        void Movement()
        {
            if (Input.GetKey(KeyCode.W))
            {
                transform.Translate(Vector3.up * movementSpeed * Time.deltaTime);
            }

            if (Input.GetKey(KeyCode.S))
            {
                transform.Translate(Vector3.down * movementSpeedback * Time.deltaTime);
            }


        }

        void Rotation()
        {
            if (Input.GetKey(KeyCode.D))
            {
                transform.Rotate(Vector3.back, rotationSpeed * Time.deltaTime);
            }

            if (Input.GetKey(KeyCode.A))
            {
                transform.Rotate(Vector3.forward, rotationSpeed * Time.deltaTime);
            }
        }

        // Update is called once per frame
        void Update()
        {
            Movement();
            Rotation();
        }
    }
}
