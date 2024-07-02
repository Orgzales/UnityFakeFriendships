using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CuffingMechanitc : MonoBehaviour
{

    public GameObject cuff;
    public bool picked_up = false;

    public GameObject owned_player;

    // Get all players
    public GameObject[] players;
    public GameObject closestPlayer = null;
    public float closestDistance = Mathf.Infinity;

    // Start is called before the first frame update
    void Start()
    {
        GameObject[] players = GameObject.FindGameObjectsWithTag("Player");
        cuff = this.gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        //when a object tagged player is close to this cuff, that cuff will follow player and is picked up
        if (Vector3.Distance(cuff.transform.position, GameObject.FindGameObjectWithTag("Player").transform.position) < 1.0f)
        {
            if (picked_up == false)
            {
                Debug.Log("Cuff is picked up");
                picked_up = true;
                owned_player = GameObject.FindGameObjectWithTag("Player");
            }
        }

        if (picked_up == true)
        {
            cuff.transform.position = GameObject.FindGameObjectWithTag("Player").transform.position;
            // Find the closest player only once later but have to make a better late update system
            Findcloestplayer();
            cuffPlayertoPillar();
        }
    }

    void cuffPlayertoPillar()
    {
        //change this to be a chain ball later but need to attach to another pillar
        //when owned player gets closed to another player, they cuff the other player

        // If the closest player is within range
        if (closestPlayer != null && closestDistance < 2.0f)
        {
            Debug.Log("Player cuffed another player");
            // Set other player's speed to 0 and set the cuff to their position
            closestPlayer.GetComponent<PlayerRunAwayTest>().playerSpeed = 0;
            cuff.transform.position = closestPlayer.transform.position;
        }
    }

    void Findcloestplayer()
    {
        // Find the closest player that is not the owned player
        foreach (GameObject player in players)
        {
            if (player != owned_player)
            {
                float distance = Vector3.Distance(owned_player.transform.position, player.transform.position);
                if (distance < closestDistance)
                {
                    closestDistance = distance;
                    closestPlayer = player;
                }
            }
        }
    }



}