using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bugs : MonoBehaviour
{
    public GameObject bug;
    public GameObject player;
    public GameObject border;
    public bool bugTouched = false;
    public float scaler;
    // Start is called before the first frame update

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            bugTouched = true;
        }
        else if (collision.tag == "Border")
        {
            bugTouched = true;
        }
        // Update is called once per frame
        void Update()
        {
            if (bugTouched == true)
            {
                Destroy(bug);
                bugTouched = false;
            }
        }
    }
}
