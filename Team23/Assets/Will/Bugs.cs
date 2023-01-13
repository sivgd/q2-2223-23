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
        else if (collision.tag == "Tongue")
        {
            //player.GetComponent<PlayerStats>().CollectedBalloon();
            Destroy(gameObject);
        }

    }

    void Update()
        {
        if (bugTouched == true)
        {
          Destroy(bug);
          bugTouched = false;
          }
        }
    }
