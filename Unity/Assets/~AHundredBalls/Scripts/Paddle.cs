using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace AHundredBalls
{
    [RequireComponent(typeof(Animator))]
    public class Paddle : MonoBehaviour
    {

        private Animator anim;

        void Start()
        {
            anim = GetComponent<Animator>();
        }

        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                anim.SetTrigger("Open");
            }
        }
    }
}