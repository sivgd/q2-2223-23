using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject player;
    public GameObject enemy;
    public bool gotHitByEnemy = false;

     void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            
            Debug.Log("Hit");
            gotHitByEnemy = true;
            if (gotHitByEnemy == true)
            {
                Debug.Log("Taken Hit");
                player.GetComponent<PlayerStats>().FrogellaHitTaken();
                gotHitByEnemy = false;
            }
        }
    }

    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
    }
}
