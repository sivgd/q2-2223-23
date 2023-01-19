using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PolutionBarColorChanges : MonoBehaviour
{
    Animator anim;
    public int cleanLevel; //max 100, min 0, starts at 50

    // Start is called before the first frame update
    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (cleanLevel > 80)
        {
            anim.SetInteger("Clean Level", 81);
        }
        else if (cleanLevel > 50)
        {
            anim.SetInteger("Clean Level", 51);
        }
        else if (cleanLevel > 20)
        {
            anim.SetInteger("Clean Level", 21);
        }
        else if (cleanLevel > 0)
        {
            anim.SetInteger("Clean Level", 19);
        }
        //polutionLevel goes up when enemy spawns
    }
}
