using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PBARMovement : MonoBehaviour
{
    public int enemies1;
    public int enemies2;
    Animator anim;
    public int cleanLevel;
    public int cleanLevel1 = 100;
    

    // Start is called before the first frame update
    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");
        
        enemies1 = enemies.Length;

        enemies2 = enemies1 * 5;
        cleanLevel = cleanLevel1 - enemies2;
        //Debug.Log(cleanLevel);

        if (cleanLevel > 100) //clean
        {
            SceneManager.LoadScene("TitleScreenScene");
        }
        else if (cleanLevel > 95)
        {
            //transform.position = new Vector3(-7.9035f, 4.871f, 0);
            transform.localPosition = new Vector3(0, 4.92f, 8.67f);
            Debug.Log("95------------------------------------------------");
            anim.SetInteger("Clean Level", 81);
        }
        else if (cleanLevel > 90)
        {
            //transform.position = new Vector3(-7.477f, 4.871f, 0);
            transform.localPosition = new Vector3(0, 4.92f, 8.67f);
            Debug.Log("90------------------------------------------------");
            anim.SetInteger("Clean Level", 81);
        }
        else if (cleanLevel > 85)
        {
            anim.SetInteger("Clean Level", 81);
            Debug.Log("85------------------------------------------------");
            //transform.position = new Vector3(-7.0505f, 4.871f, 0);
            transform.localPosition = new Vector3(0, 4.92f, 8.67f);
        }
        else if (cleanLevel > 80)
        {
            anim.SetInteger("Clean Level", 81);
            //transform.position = new Vector3(-6.624f, 4.871f, 0);
            transform.localPosition = new Vector3(0, 4.92f, 8.67f);
        }
        else if (cleanLevel > 75)
        {
            //transform.position = new Vector3(-6.1975f, 4.871f, 0);
            transform.localPosition = new Vector3(0, 4.92f, 8.67f);
            anim.SetInteger("Clean Level", 51);
        }
        else if (cleanLevel > 70)
        {
            //transform.position = new Vector3(-5.771f, 4.871f, 0);
            transform.localPosition = new Vector3(0, 4.92f, 8.67f);
            anim.SetInteger("Clean Level", 51);
        }
        else if (cleanLevel > 65)
        {
            //transform.position = new Vector3(-5.3445f, 4.871f, 0);
            transform.localPosition = new Vector3(0, 4.92f, 8.67f);
            anim.SetInteger("Clean Level", 51);
        }
        else if (cleanLevel > 60)
        {
            //transform.position = new Vector3(-4.918f, 4.871f, 0);
            transform.localPosition = new Vector3(0, 4.92f, 8.67f);
            anim.SetInteger("Clean Level", 51);
        }
        else if (cleanLevel > 55)
        {
            anim.SetInteger("Clean Level", 51);
            //transform.position = new Vector3(-4.4915f, 4.871f, 8.83f);
            transform.localPosition = new Vector3(0, 4.92f, 8.67f);
        }
        else if (cleanLevel > 50)
        {
            anim.SetInteger("Clean Level", 51);
            //transform.position = new Vector3(-4.065f, 3.46f, 8.83f);
            transform.localPosition = new Vector3(0, 4.92f, 8.67f);
        }
        else if (cleanLevel > 45)
        {
            //transform.position = new Vector3(-3.6385f, 3.46f, 8.83f);
            transform.localPosition = new Vector3(0, 4.92f, 8.67f);
            anim.SetInteger("Clean Level", 21);
        }
        else if (cleanLevel > 40)
        {
            //transform.position = new Vector3(-3.212f, 3.46f, 8.83f);
            transform.localPosition = new Vector3(0, 4.92f, 8.67f);
            anim.SetInteger("Clean Level", 21);
        }
        else if (cleanLevel > 35)
        {
            //transform.position = new Vector3(-2.7855f, 3.46f, 8.83f);
            transform.localPosition = new Vector3(0, 4.92f, 8.67f);
            anim.SetInteger("Clean Level", 21);
        }
        else if (cleanLevel > 30)
        {
            Debug.Log("30");
            //transform.position = new Vector3(-2.359f, 3.46f, 8.83f);
            transform.localPosition = new Vector3(0, 4.92f, 8.67f);
            anim.SetInteger("Clean Level", 21);
        }
        else if (cleanLevel > 25)
        {
            anim.SetInteger("Clean Level", 21);
            //transform.position = new Vector3(-1.9325f, 3.46f, 8.83f);
            transform.localPosition = new Vector3(0, 4.92f, 8.67f);
        }
        else if (cleanLevel > 20)
        {
            anim.SetInteger("Clean Level", 21);
            //transform.position = new Vector3(-1.506f, 3.46f, 8.83f);
            transform.localPosition = new Vector3(0, 4.92f, 8.67f);
        }
        else if (cleanLevel > 15)
        {
            //transform.position = new Vector3(-1.0795f, 3.46f, 8.83f);
            anim.SetInteger("Clean Level", 19);
            transform.localPosition = new Vector3(0, 4.92f, 8.67f);
        }
        else if (cleanLevel > 10)
        {
            //transform.position = new Vector3(-0.653f, 3.46f, 8.83f);
            transform.localPosition = new Vector3(0, 4.92f, 8.67f);
            anim.SetInteger("Clean Level", 19);
        }
        else if (cleanLevel > 5)
        {
            anim.SetInteger("Clean Level", 19);
            //transform.position = new Vector3(-0.2265f, 3.46f, 8.83f);
            transform.localPosition = new Vector3(0, 4.92f, 8.67f);
        }
        else if (cleanLevel > 0)
        {
            Debug.Log("00000000000000000000000000");
            anim.SetInteger("Clean Level", 19);
            //transform.position = new Vector3(0.1f, 3.46f, 8.83f);
            transform.localPosition = new Vector3(0, 4.92f, 8.67f);
        }
        else if (cleanLevel <= 0) //dirty
        {
            SceneManager.LoadScene("TitleScreenScene");
        }

        
    }

}
