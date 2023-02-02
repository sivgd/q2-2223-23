using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeNoise : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {


            Debug.Log("---------------------------------------PLAY SOUND");
            GetComponent<AudioSource>().Play();
        }
    }
    
}
