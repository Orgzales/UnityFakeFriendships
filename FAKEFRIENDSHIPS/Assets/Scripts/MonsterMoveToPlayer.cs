using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterMoveToPlayer : MonoBehaviour
{
    public GameObject monster;
    public GameObject closest_target;

    public float mosnterSpeed = 2.0f;

    // Start is called before the first frame update
    void Start()
    {
        //find the nearest player and make it the cloest_target
        GameObject[] players = GameObject.FindGameObjectsWithTag("Player");
        float minDistance = Mathf.Infinity;
        foreach (GameObject player in players)
        {
            float distance = Vector3.Distance(monster.transform.position, player.transform.position);
            if (distance < minDistance)
            {
                minDistance = distance;
                closest_target = player;
            }
        }

    }

    // Update is called once per frame
    void Update()
    {
        //move to the cloest target 
        monster.transform.position = Vector3.MoveTowards(monster.transform.position, closest_target.transform.position, mosnterSpeed * Time.deltaTime);

    }
}
