using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bugs : MonoBehaviour
{
    public GameObject bug;
    public GameObject player;
    public bool bugTouched = false;
    public float scaler;
    // Start is called before the first frame update

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Border")
        {
                Destroy(gameObject);
        }
        if (collision.tag == "Player")
        {
            if (player.GetComponent<PlayerStats>().bugsCollected == false)
            {
                Debug.Log("Collected");
                bugTouched = true;
            }
        }

    }

    void Update()
        {
        if (bugTouched == true)
        {
            if (player.GetComponent<PlayerStats>().bugsCollected == false)
            {
                Debug.Log("Collected and destroyed");
                Destroy(bug);
                player.GetComponent<PlayerStats>().CollectedBug();
                bugTouched = false;
            }
            else if (player.GetComponent<PlayerStats>().bugsCollected == true)
            {
                bugTouched = false;
            }

            }
        }
    }
