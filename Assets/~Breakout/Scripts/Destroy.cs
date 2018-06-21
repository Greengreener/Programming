using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


namespace Breakout
{
    public class Destroy : MonoBehaviour
    {
        public static int counter = 0;
        public Text counterText;
        void Start()
        {
            counter = 0;
        }
        void LateUpdate()
        {
            counterText.text = counter.ToString();
            // makes counter start at zero
        }
        void OnCollisionEnter2D(Collision2D coll) // Detects collision
        {
            if (coll.gameObject.tag == "Block") // Detect if collider has the block tag
            {
                Destroy(coll.gameObject); //Destroys the block
                counter++; // Adds to the counter
                
            }
            if (coll.gameObject.tag == "Death") // Detect if collider has the block tag
            {
                SceneManager.LoadScene(3);

            }
        }
    }
}