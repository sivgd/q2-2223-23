using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IgnoreCollider : MonoBehaviour
{
    public GameObject item1;
    public GameObject item2;
    public GameObject item3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Physics2D.IgnoreCollision(item1.collider2D, item2.collider2D, item3.collider2D);
    }
}
