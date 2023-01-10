using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovement : MonoBehaviour
{
    float movespeed = 10f;

    Rigidbody2D rb;

    Frogella target;
    Vector2 moveDirection;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent < Rigidbody2D> ();
        target = GameObject.FindObjectOfType<Frogella>();
        moveDirection = (target.transform.position - transform.position).normalized * movespeed;
        rb.velocity = new Vector2(moveDirection.x, moveDirection.y);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.name.Equals ("Frogella"))
        {
            Debug.Log("Hit");
            Destroy(gameObject);
        }
    }
}
