using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeginningRulesControls : MonoBehaviour
{
    public GameObject ohFrogella;
    public GameObject control;
    public GameObject rule;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 0f;
        ohFrogella.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ohNo()
    {
        ohFrogella.SetActive(false);
        control.SetActive(true);

    }

    public void cControls()
    {
        control.SetActive(false);
        rule.SetActive(true);
    }

    public void Rules()
    {
        rule.SetActive(false);
        Time.timeScale = 1f;
    }
}
