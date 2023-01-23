using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrogellaSpriteChanges : MonoBehaviour
{
    Animator anim;
    // Update is called once per frame
    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
    }

    void Update()
    {
        if (GetComponent<PlayerStats>().bugsCollected == true)
        {
            anim.SetBool("BugCollected", true);
        }
        if (GetComponent<PlayerStats>().shotBug == true)
        {
            anim.SetBool("ShotBug", true);
            anim.SetBool("BugCollected", false);
        }
    }
}
