using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
    public static bool tP = true;
    public static bool aP = false;
    public static bool kP = false;
    public static bool kbP = false;
    public static bool lP = false;
    public static bool mP = false;
    public static bool miP = false;
    public static bool wP = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Change()
    {
        titlePage.SetActive(false);
        tP = false;
        annikaPage.SetActive(true);
        aP = true;
        if (tP == false && aP == true)
        {
           annikaPage.SetActive(false);
           aP = false;
           kylePage.SetActive(true);
           kP = true;
        }
    }
}
