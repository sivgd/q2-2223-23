using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeLayer : MonoBehaviour
{
    public GameObject titlePage;
    public GameObject annikaPage;
    public GameObject kylePage;
    public GameObject kimberlyPage;
    public GameObject kimPage2;
    public GameObject lizzyPage;
    public GameObject marcusPage;
    public GameObject miaPage;
    public GameObject willPage;
    public GameObject thankYou;
    int counter = 0;

    // Start is called before the first frame update
    void Start()
    {
        titlePage.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (counter == 1)
        {
            titlePage.SetActive(false);
            annikaPage.SetActive(true);
        }

        if (counter == 2)
        {
            annikaPage.SetActive(false);
            kylePage.SetActive(true);
        }

        if (counter == 3)
        {
            kylePage.SetActive(false);
            kimberlyPage.SetActive(true);
        }

        if (counter == 4)
        {
            kimberlyPage.SetActive(false);
            kimPage2.SetActive(true);
        }

        if (counter == 5)
        {
            kimPage2.SetActive(false);
            lizzyPage.SetActive(true);
        }

        if (counter == 6)
        {
            lizzyPage.SetActive(false);
            marcusPage.SetActive(true);
        }

        if (counter == 7)
        {
            marcusPage.SetActive(false);
            miaPage.SetActive(true);
        }

        if (counter == 8)
        {
            miaPage.SetActive(false);
            willPage.SetActive(true);
        }

        if (counter == 9)
        {
            willPage.SetActive(false);
            thankYou.SetActive(true);
        }

        if (counter == 10)
        {
            SceneManager.LoadScene("TitleScreenScene");
        }
    }

    public void ButtonClick()
    {
        counter++;
    }

   
}
