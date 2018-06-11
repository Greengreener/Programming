using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Assessment1
{
    public class Player_movement : MonoBehaviour
    {
        public float movementSpeed = 10f;
        public Vector2[] directions = new Vector2[]
            {
        new Vector2(-1, 1f),
        new Vector2(1f,1f)
            };

        // Use this for initialization
        void Start()
        {

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

        }
    }
}