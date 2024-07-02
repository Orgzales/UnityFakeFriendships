using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CuffingMechanitc : MonoBehaviour
{

    public GameObject cuff;
    public bool picked_up = false;


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
            picked_up = true;
            cuff.transform.position = GameObject.FindGameObjectWithTag("Player").transform.position;
        }


    }
}
