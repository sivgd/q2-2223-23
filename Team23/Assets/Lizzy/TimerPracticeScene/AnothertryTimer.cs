using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class AnothertryTimer : MonoBehaviour
{
    public NewPBAR script;

    public float timeValue = 5;

    public Text timeText;

    public bool timerIsRunning = false;

    public GameObject bar;
    public int cleanLevel;

    public int anything; 
    private void Start()
    {
        timerIsRunning = true;
      

    }
    // Update is called once per frame
    void Update()
    {
        if (timerIsRunning)
        {


            if (timeValue > 0)
            {
                timeValue -= Time.deltaTime;

            }else if (cleanLevel < 50) 
            {

                Debug.Log("Time has run out!");
                timeValue = 0;
                timerIsRunning = false;
                Application.LoadLevel("GameOver");

            }else if (cleanLevel > 50) 

            {
                timeValue = 0;
                timerIsRunning = false;
                Application.LoadLevel("WinScene");
            }

            DisplayTime(timeValue);
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
