using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balloon : MonoBehaviour

{
    public GameObject player;
    public GameObject balloon;
    public bool touchedBalloon = false;
    //OnTriggerEnter(Collider Col)
    //{
        //if (col.collider.name == "Frogella")
        //{
            //touchedBalloon == true;
        //}
    //}

    void Update()



    {
        if (touchedBalloon == true)
        {
            Debug.Log("Collected!");
            player.GetComponent<PlayerStats>().CollectedBalloon();
            touchedBalloon = false;
        }

    }

}
