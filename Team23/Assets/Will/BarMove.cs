using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarMove : MonoBehaviour
{
    public float cleanLevel;
    public GameObject bar;
    // Start is called before the first frame update
    void Start()
    {

    }




    // Update is called once per frame
    public void barmoveenemyspawn()
    {
        bar.transform.position -= new Vector3(0.437f, 0, 0);
    }
    public void barmovedestroy()
    {
        bar.transform.position += new Vector3(0.437f, 0, 0);
    }

}
//-8.28 bar empty, 0.46 bar full
//0.0874 per hp