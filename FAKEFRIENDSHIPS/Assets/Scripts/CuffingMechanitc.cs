using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CuffingMechanitc : MonoBehaviour
{

    public GameObject cuff;
    public bool picked_up = false;

    public GameObject owned_player;

    // Start is called before the first frame update
    void Start()
    {
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
        }


    }

    void cuffPlayertoPillar()
    {
        //when owned player gets closed to another player, they cuff them
        if (Vector3.Distance(owned_player.transform.position, GameObject.FindGameObjectWithTag("Player").transform.position) < 1.0f)
        {
            Debug.Log("Player cuffed another player");
            //set other player speed to 0 and set the cuff to their position
            GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerRunAwayTest>().playerSpeed = 0;
            cuff.transform.position = GameObject.FindGameObjectWithTag("Player").transform.position;
        }
    }


}
