using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class AnothertryTimer : MonoBehaviour
{
    public float timeValue = 5;

    public Text timeText;


    // Update is called once per frame
    void Update()
    {

        if (timeValue > 0)
        {
            timeValue -= Time.deltaTime;

        } else
        {
            timeValue = 0;
        }


    }

    void DisplayTime(float timeToDisplay)
    {
        if (timeToDisplay < 0)
        {
            timeToDisplay = 0;
        }

        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);

        timeText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }

}
