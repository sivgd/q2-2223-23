using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowSpriteChange : MonoBehaviour
{
    public SpriteRenderer rend;

    // Start is called before the first frame update
    void Start()
    {
        rend = this.gameObject.GetComponent<SpriteRenderer>();
        rend.enabled = true;

    }

    // Update is called once per frame
    void Update()
    {
        if (GetComponent<PlayerStats>().bugsCollected == true)
        {
            rend.enabled = !rend.enabled;
        }

    }
}
