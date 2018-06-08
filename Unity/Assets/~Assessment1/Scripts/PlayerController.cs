﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Assessment1
{
    
    public class PlayerController : MonoBehaviour
    {

        public float movement = 0f;

        Rigidbody2D rb;

        // Use this for initialization
        void Start()
        {
            rb = GetComponent<Rigidbody2D>();
        }

        // Update is called once per frame
        void Update()
        {
            movement = Input.GetAxis("Horizontal");
        }

        void FixedUpdate()
        {
            Vector2 velocity = rb.velocity;
            velocity.x = movement;
            rb.velocity = velocity;
        }
    }
}