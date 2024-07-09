using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

GameObject player;

NavMeshAgent agent;

[SerializeField] LayerMask GroundLayer, PlayerLayer;


//roaming
Vector3 destinationPoint;
bool walkpointset;

[SerializeField] float walkrange; //how far the enemy can walk

public class RoamingAI : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void roam()
    {
        if(!walkpointset)
        {

        }
        if(walkpointset)
        {
            agent.SetDestination(destinationPoint);
        }
        if(Vector3.Distance(transform.position, destinationPoint) <= 10) 
        {
            walkpointset = false;
        }

    }

    void SearchforDest()
    {
        
    }

}
