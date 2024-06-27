using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRunAwayTest : MonoBehaviour
{

    public GameObject player;
    public GameObject closest_Exit;
    public bool Death = false;
    public GameObject monster;

    public float playerSpeed = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        //find the nearest exit and make it the cloest_Exit
        GameObject[] exits = GameObject.FindGameObjectsWithTag("Exit");
        float minDistance = Mathf.Infinity;
        foreach (GameObject exit in exits)
        {
            float distance = Vector3.Distance(player.transform.position, exit.transform.position);
            if (distance < minDistance)
            {
                minDistance = distance;
                closest_Exit = exit;
            }
        }

    }

    // Update is called once per frame
    void Update()
    {
        //have players move to the cloest exit
        player.transform.position = Vector3.MoveTowards(player.transform.position, closest_Exit.transform.position, playerSpeed * Time.deltaTime);

        //if player is touched by monster = true -  then Death is true
        if (Vector3.Distance(player.transform.position, monster.transform.position) < 1.0f)
        {
            Death = true;
        }

        if (Death == true)
        {
            playerSpeed = 0;
        }


    }
}
