using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject player;
    public GameObject enemy;
    public bool gotHitByEnemy = false;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Enemy")
        {
            Debug.Log("Hit");
            gotHitByEnemy = true;
        }
    }

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (gotHitByEnemy == true)
        {
            Debug.Log("Taken Hit");
            player.GetComponent<PlayerStats>().frogellaHitTaken();
            gotHitByEnemy = false;
        }
    }
}
