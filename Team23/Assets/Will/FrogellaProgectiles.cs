using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrogellaProgectiles : MonoBehaviour
{
    public GameObject projectile;
    public GameObject enemy;
    public bool Hitenemy = false;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "spit")
        {

            Debug.Log("Hit enemy");
            Hitenemy = true;
            if (Hitenemy == true)
            {
                Debug.Log("Detroyed and Hit");
                Destroy(gameObject);
                Hitenemy = false;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
