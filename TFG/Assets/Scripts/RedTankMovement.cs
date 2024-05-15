using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.AI;

public class RedTankMovement : MonoBehaviour
{
    public GameObject destination;
    public NavMeshAgent agent;

    private void Start()
    {       
       agent.speed = 10f;
    }

    // Update is called once per frame
    void Update()
    {
        if (destination != null)
        {
            agent.SetDestination(destination.transform.position);
        }
    }
}
