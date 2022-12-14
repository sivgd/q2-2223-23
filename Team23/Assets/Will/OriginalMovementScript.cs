using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OriginalMovementScript : MonoBehaviour
{
    public GameObject player;
    bool grounded = false;
    Rigidbody2D rb2;
    SpriteRenderer sr;
    public float scaler;
    // Start is called before the first frame update
    void Start()
    {

        rb2 = gameObject.GetComponent<Rigidbody2D>();
        sr = gameObject.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (player.GetComponent<PlayerStats>().balloons <= 0)
        {
            float horizValue = Input.GetAxis("Horizontal");
            rb2.velocity = new Vector2(horizValue * 5, rb2.velocity.y);

            if (horizValue > 0)
            {
                sr.flipX = true;
            }
            else
            {
                sr.flipX = false;
            }

            grounded = Physics2D.BoxCast(transform.position, new Vector2(0.1f, 0.1f), 0, Vector2.down, 1, LayerMask.GetMask("Ground"));
            if (grounded && Input.GetKeyDown(KeyCode.Space))
            {
                rb2.velocity = new Vector2(rb2.velocity.x, 8);
            }
        }
        else if (player.GetComponent<PlayerStats>().balloons >= 0)
        {
        float inX = Time.deltaTime * scaler * Input.GetAxis("Horizontal");
        float inY = Time.deltaTime * scaler * Input.GetAxis("Vertical");
        transform.position += new Vector3(inX, inY, 0);
        Debug.Log(inX + ", " + inY);
        }
       
    }
}
