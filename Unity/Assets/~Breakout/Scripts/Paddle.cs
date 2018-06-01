using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Breakout
{
    public class Paddle : MonoBehaviour
    {
        /*
         int        whole number 1
         float      decimal number 0.28596325474
         string     symbols 25 kLOp@3>/} :`!
         bool       TRUE OR FALSE two states on or off, yes or no 
         */
        //away to check if we have fired
        public bool fired; //if you dont declare the start value its false
        public float movementSpeed = 10f;
        public Ball currentBall;
        public Vector2[] directions = new Vector2[]
        {
        new Vector2(-1, 1f),
        new Vector2(1f,1f)
        };

        // Use this for initialization
        void Start()
        {
            currentBall = GetComponentInChildren<Ball>();
        }

        void Fire()
        {
            currentBall.transform.SetParent(null);
            Vector3 randomDir = directions[Random.Range(0, directions.Length)];
            currentBall.Fire(randomDir);
            //set that we have fired
            fired = true;
        }

        void CheckInput()
        {
            //only fire if we havent fired yet
            if (!fired)/*fired == false*/ // checks if the ball has been fired - if not 
            {
                if (Input.GetKeyDown(KeyCode.Space))
                {
                    Fire();
                }
            }
           
        }

        void Movement()
        {
            float inputH = Input.GetAxis("Horizontal");
            Vector3 force = transform.right * inputH;
            force *= movementSpeed;
            force *= Time.deltaTime;
            transform.position += force;
        }

        // Update is called once per frame
        void Update()
        {
            CheckInput();
            Movement();
        }
    }
}