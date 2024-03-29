using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balloon : MonoBehaviour

{
    public GameObject player;
    public GameObject balloon;
    public bool touchedBalloon = false;
    public float scaler;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            if (player.GetComponent<PlayerStats>().balloons < 3)
            {
                Debug.Log("Collected");
                touchedBalloon = true;
            }
        }
        else if (collision.tag == "Border")
        {
            Destroy(gameObject);
        }
    }
    void Update()

 

        {
        if (touchedBalloon == true)
        {
            Debug.Log("Collected!!!!");
            player.GetComponent<PlayerStats>().CollectedBalloon();
            Destroy(balloon);
            touchedBalloon = false;
        }

        

    }
}
