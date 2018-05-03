using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.AI;

namespace GoneHome
{
    public class FollowEnemy : MonoBehaviour
    {
        public Transform target;
        private NavMeshAgent agent;

        private Vector3 spawnPoint;

        void Start()
        {
            agent = GetComponent<NavMeshAgent>();

            spawnPoint = transform.position;
        }

        // Update is called once per frame
        void Update()
        {
            agent.SetDestination(target.position);
        }

        internal void Reset()
        {
            agent.enabled = false;
            transform.position = spawnPoint;
            agent.enabled = true;
        }
    }
}
