using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.AI; 

namespace GoneHome
{
    public class Enemy : MonoBehaviour
    {
        public Transform target;

        private NavMeshAgent agent;

        
        void Start()
        {
            agent = GetComponent<NavMeshAgent>();
        }

        // Update is called once per frame
        void Update()
        {
            agent.SetDestination(target.position);
        }
    }
}
