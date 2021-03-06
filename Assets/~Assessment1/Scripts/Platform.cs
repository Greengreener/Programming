﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Assessment1
{
    public class Platform : MonoBehaviour
    {

        public float jumpForce = 10f;

       void OnCollisionEnter2D(Collision2D coll) // Detects collisions entering and forces detected collision to "Jump up"
        {
            if (coll.relativeVelocity.y >= 0f)
            {
                Rigidbody2D rb = coll.collider.GetComponent<Rigidbody2D>();
                if (rb != null)
                {
                    Vector2 velocity = rb.velocity;
                    velocity.y = jumpForce;
                    rb.velocity = velocity;
                }
            }
        }
    }
}