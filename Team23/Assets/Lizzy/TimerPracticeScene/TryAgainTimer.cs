using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class TryAgainTimer : MonoBehaviour
{
    public float TimeLeft;
    public bool TimerOn = false;

    public TMP_Text TimerTxt;

    
    // Start is called before the first frame update
    void Start()
    {
        TimerOn = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (TimerOn)
        {
            if (TimeLeft > 0)
            {
                TimeLeft -= Time.deltaTime;
            }
            else
            {
                Debug.Log("Time is up");
                TimeLeft = 0;
                TimerOn = false;
            }
        }

        //void DisplayTime(float timeToDisplay)
        //{
            //timeToDisplay += 1;

            //float minutes = Mathf.FloorToInt(currentTime / 60);
            //float seconds = Mathf.FloorToInt(currentTime % 60);

            //TimerTxt.text = string.Format("{0:00} : {1:00}", minutes, seconds);

            
        //}
    }
}
