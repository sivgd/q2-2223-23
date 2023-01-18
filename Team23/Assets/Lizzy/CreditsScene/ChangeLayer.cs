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
            lizzyPage.SetActive(true);
        }

        if (counter == 5)
        {
            lizzyPage.SetActive(false);
            marcusPage.SetActive(true);
        }

        if (counter == 6)
        {
            marcusPage.SetActive(false);
            miaPage.SetActive(true);
        }

        if (counter == 7)
        {
            miaPage.SetActive(false);
            willPage.SetActive(true);
        }

        if (counter == 8)
        {
            willPage.SetActive(false);
            thankYou.SetActive(true);
        }

        if (counter == 9)
        {
            SceneManager.LoadScene("TitleScreenScene");
        }
    }

    public void ButtonClick()
    {
        counter++;
    }

   
}
