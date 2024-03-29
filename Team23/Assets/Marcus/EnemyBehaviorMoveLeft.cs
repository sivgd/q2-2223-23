using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaviorMoveLeft : MonoBehaviour
{
    float moveSpeed = 1f;

    Rigidbody2D myRigidbody;
    public GameObject trap;

    // Start is called before the first frame update
    void Start()
    {
        myRigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(IsFacingRight())
        {
            //Move right
            myRigidbody.velocity = new Vector2(-moveSpeed, 0f);
            
        }
        else
        {
            //Move left
            myRigidbody.velocity = new Vector2(moveSpeed, 0f);
        }
    }
    private bool IsFacingRight()
    {
        return transform.localScale.x > Mathf.Epsilon;
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        //Turn
        
        transform.localScale = new Vector3(-transform.localScale.x, transform.localScale.y, transform.localScale.z);
        
    }
}
