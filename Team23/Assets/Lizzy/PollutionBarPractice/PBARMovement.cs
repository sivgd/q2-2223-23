using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PBARMovement : MonoBehaviour
{
    public int enemies1;
    Animator anim;
    public int cleanLevel;
    public GameObject bar;

    // Start is called before the first frame update
    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        GameObject[] enemies = GameObject.FindGameObjectsWithTag("LizzyEnemy");
        
        enemies1 = enemies.Length;

        //cleanLevel = enemies1 * 10;

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
    }
}
