﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Assessment1
{
    public class Player_movement : MonoBehaviour
    {
        public float movementSpeed = 0.1f;

        void Movement()
        {
            // Move right
            if (Input.GetKey(KeyCode.D))
            {
                transform.Translate(Vector2.right * movementSpeed * Time.deltaTime);
            }
            // Move right
            if (Input.GetKey(KeyCode.A))
            {
                transform.Translate(Vector2.left * movementSpeed * Time.deltaTime);
            }
        }
        void Update()
        {
            Movement();
        }
    }
}