using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GoneHome
{
    public class Player : MonoBehaviour
    {

        public float acceleration = 20f;
        public float maxVelocity = 10f;

        private Rigidbody rigid;
        private Vector3 spawnPoint;

        // Use this for initialization
        void Start()
        {
            rigid = GetComponent<Rigidbody>();

            spawnPoint = transform.position;
        }

        // Update is called once per frame
        void Update()
        {
            float inputH = Input.GetAxis("Horizontal");
            float inputV = Input.GetAxis("Vertical");

            Vector3 inputDir = new Vector3(inputH, 0, inputV);

            rigid.AddForce(inputDir * acceleration);

            if(rigid.velocity.magnitude > maxVelocity)
            {
                rigid.velocity = rigid.velocity.normalized * maxVelocity;
            }
        }

        public void Reset()
        {
            transform.position = spawnPoint;
        }
    }
}
