using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnothertryTimer : MonoBehaviour
{
    public float timeValue = 90;

   

    // Update is called once per frame
    void Update()
    {
        if (timeValue > 0)
        {
            timeValue -= Time.deltaTime;

        }else
        {
            timeValue = 0;
        }
        
    }
}
