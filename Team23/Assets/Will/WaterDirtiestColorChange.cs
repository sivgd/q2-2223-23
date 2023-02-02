using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class WaterDirtiestColorChange : MonoBehaviour
{
    // Start is called before the first frame update
    public TilemapRenderer rend;
    public GameObject polution;
    // Start is called before the first frame update
    void Start()
    {
        rend = this.gameObject.GetComponent<TilemapRenderer>();
        rend.enabled = true;

    }

    // Update is called once per frame
    void Update()
    {
        int p = polution.GetComponent<NewPBAR>().cleanLevel;

        if (p <= 20 && p > 0)
        {
            rend.enabled = true;
        }
        if (p > 20)
        {
            rend.enabled = false;
        }
    }
}
