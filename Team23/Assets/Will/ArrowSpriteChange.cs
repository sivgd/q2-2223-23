using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowSpriteChange : MonoBehaviour
{
    public SpriteRenderer rend;
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        rend = this.gameObject.GetComponent<SpriteRenderer>();
        rend.enabled = true;

    }

    // Update is called once per frame
    void Update()
    {
        if (player.GetComponent<PlayerStats>().bugsCollected == true)
        {
            rend.enabled = true;
        }
        if (player.GetComponent<PlayerStats>().bugsCollected == false)
        {
            rend.enabled = false;
        }

    }
}
