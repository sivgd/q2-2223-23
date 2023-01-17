using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PolutionBarColorChanges : MonoBehaviour
{
    Animator animator;

    public int polutionLevel; //max 100, min 0, starts at 50

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //polutionLevel goes up when enemy spawns
    }
}
