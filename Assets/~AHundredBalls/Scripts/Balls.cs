﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace AHundredBalls
{
    public class Balls : MonoBehaviour
    {
        public void OnTriggerEnter2D(Collider2D col)
        {
            if (col.name.Contains("Bucket"))
            {
                transform.SetParent(col.transform);
            }
        }
    }
}