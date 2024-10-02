using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class RoamingAI : MonoBehaviour
{

    GameObject player;

    NavMeshAgent agent;

    [SerializeField] LayerMask GroundLayer, PlayerLayer;


    //roaming
    Vector3 destinationPoint;
    bool walkpointset;
    [SerializeField] float walkrange; //how far the enemy can walk

    //state change
    [SerializeField] float sightRange, attackRange;
    bool playerInSight, playerinattackrange;


    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {

        playerInSight = Physics.CheckSphere(transform.position, sightRange, PlayerLayer);
        playerinattackrange = Physics.CheckSphere(transform.position, attackRange, PlayerLayer);

        if (!playerInSight && !playerinattackrange) roam(); //random moving AI
        if (playerInSight && !playerinattackrange) Chase(); //chase player AI
        if (playerInSight && playerinattackrange) Attack(); //attack player AI
    }

    void roam()
    {
        if (!walkpointset)
        {
            SearchforDest();
        }
        if (walkpointset)
        {
            agent.SetDestination(destinationPoint);
        }
        if (Vector3.Distance(transform.position, destinationPoint) <= 10)
        {
            walkpointset = false;
        }

    }

    void Chase()
    {
        agent.SetDestination(player.transform.position);
    }

    void Attack()
    {
        //attack player
        debug.log("attacking player");
    }

    void SearchforDest()
    {
        float z = Random.Range(-walkrange, walkrange);
        float x = Random.Range(-walkrange, walkrange);

        destinationPoint = new Vector3(transform.position.x + x, transform.position.y, transform.position.z + z);
        if (Physics.Raycast(destinationPoint, Vector3.down, GroundLayer))
        {
            walkpointset = true;
        }
    }

}
