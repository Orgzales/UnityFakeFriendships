using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CuffingMechanitc : MonoBehaviour
{
    public GameObject cuff;
    public bool picked_up = false;
    public bool used_item = false;
    public GameObject owned_player;
    public float pickUpRadius = 1.0f;
    public float cuffRadius = 2.0f;

    // Start is called before the first frame update
    void Start()
    {
        cuff = this.gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        if (!used_item)
        {
            if (!picked_up)
            {
                PickupCuff();
            }
            else
            {
                Followplayer();
                CuffOtherplayer();
            }
        }


    }

    void PickupCuff()
    {
        if (Vector3.Distance(cuff.transform.position, GameObject.FindGameObjectWithTag("Player").transform.position) < pickUpRadius)
        {

            Debug.Log("Cuff is picked up");
            picked_up = true;
            owned_player = GameObject.FindGameObjectWithTag("Player");
        }
    }

    void Followplayer()
    {
        if (owned_player != null)
        {
            cuff.transform.position = owned_player.transform.position;
        }
    }

    void CuffOtherplayer()
    {
        GameObject[] players = GameObject.FindGameObjectsWithTag("Player");
        foreach (GameObject player in players)
        {
            if (player != owned_player && Vector3.Distance(owned_player.transform.position, player.transform.position) < cuffRadius)
            {
                Debug.Log("Player cuffed another player");
                // Move the cuff to the other player's position
                player.GetComponent<PlayerRunAwayTest>().playerSpeed = 0.0f;
                cuff.transform.position = player.transform.position;
                used_item = true;
                break;
            }
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("Player cuffed another player");
            // Move the cuff to the other player's position
            collision.gameObject.GetComponent<PlayerRunAwayTest>().playerSpeed = 0.0f;
            cuff.transform.position = collision.gameObject.transform.position;
            used_item = true;
        }
    }


}