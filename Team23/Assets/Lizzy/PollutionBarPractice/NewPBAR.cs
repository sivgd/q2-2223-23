using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewPBAR : MonoBehaviour
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

        if (cleanLevel > 100)
        {
            SceneManager.LoadScene("WinScene");
        }
        else if (cleanLevel > 95)
        {
            //transform.position = new Vector3(-7.9035f, 3.46f, 8.83f);
            transform.localPosition = new Vector3(-1.1244f, 0.03f, 0.0775f);
            anim.SetInteger("Clean Level", 81);
        }
        else if (cleanLevel > 90)
        {
            //transform.position = new Vector3(-7.477f, 3.46f, 8.83f);
            transform.localPosition = new Vector3(-1.0638f, 0.03f, 0.0775f);
            anim.SetInteger("Clean Level", 81);
        }
        else if (cleanLevel > 85)
        {
            anim.SetInteger("Clean Level", 81);
            transform.localPosition = new Vector3(-1.0032f, 0.03f, 0.0775f);
            //transform.position = new Vector3(-7.0505f, 3.46f, 8.83f);
        }
        else if (cleanLevel > 80)
        {
            anim.SetInteger("Clean Level", 81);
            transform.localPosition = new Vector3(-0.9426f, 0.03f, 0.0775f);
            //transform.position = new Vector3(-6.624f, 3.46f, 8.83f);
        }
        else if (cleanLevel > 75)
        {
            //transform.position = new Vector3(-6.1975f, 3.46f, 8.83f);
            transform.localPosition = new Vector3(-0.882f, 0.03f, 0.0775f);
            anim.SetInteger("Clean Level", 51);
        }
        else if (cleanLevel > 70)
        {
            //transform.position = new Vector3(-5.771f, 3.46f, 8.83f);
            transform.localPosition = new Vector3(-0.8214f, 0.03f, 0.0775f);
            anim.SetInteger("Clean Level", 51);
        }
        else if (cleanLevel > 65)
        {
            //transform.position = new Vector3(-5.3445f, 3.46f, 8.83f);
            transform.localPosition = new Vector3(-0.7608f, 0.03f, 0.0775f);
            anim.SetInteger("Clean Level", 51);
        }
        else if (cleanLevel > 60)
        {
            //transform.position = new Vector3(-4.918f, 3.46f, 8.83f);
            transform.localPosition = new Vector3(-0.7002f, 0.03f, 0.0775f);
            anim.SetInteger("Clean Level", 51);
        }
        else if (cleanLevel > 55)
        {
            anim.SetInteger("Clean Level", 51);
            transform.localPosition = new Vector3(-0.6396f, 0.03f, 0.0775f);
            //transform.position = new Vector3(-4.4915f, 3.46f, 8.83f);
        }
        else if (cleanLevel > 50)
        {
            anim.SetInteger("Clean Level", 51);
            transform.localPosition = new Vector3(-0.579f, 0.03f, 0.0775f);
            //transform.position = new Vector3(-4.065f, 3.46f, 8.83f);
        }
        else if (cleanLevel > 45)
        {
            //transform.position = new Vector3(-3.6385f, 3.46f, 8.83f);
            transform.localPosition = new Vector3(-0.5184f, 0.03f, 0.0775f);
            anim.SetInteger("Clean Level", 21);
        }
        else if (cleanLevel > 40)
        {
            //transform.position = new Vector3(-3.212f, 3.46f, 8.83f);
            transform.localPosition = new Vector3(-0.4578f, 0.03f, 0.0775f);
            anim.SetInteger("Clean Level", 21);
        }
        else if (cleanLevel > 35)
        {
            //transform.position = new Vector3(-2.7855f, 3.46f, 8.83f);
            transform.localPosition = new Vector3(-0.3972f, 0.03f, 0.0775f);
            anim.SetInteger("Clean Level", 21);
        }
        else if (cleanLevel > 30)
        {
            //transform.position = new Vector3(-2.359f, 3.46f, 8.83f);
            transform.localPosition = new Vector3(-0.3366f, 0.03f, 0.0775f);
            anim.SetInteger("Clean Level", 21);
        }
        else if (cleanLevel > 25)
        {
            anim.SetInteger("Clean Level", 21);
            transform.localPosition = new Vector3(-0.276f, 0.03f, 0.0775f);
            //transform.position = new Vector3(-1.9325f, 3.46f, 8.83f);
        }
        else if (cleanLevel > 20)
        {
            anim.SetInteger("Clean Level", 21);
            transform.localPosition = new Vector3(-0.2154f, 0.03f, 0.0775f);
            //transform.position = new Vector3(-1.506f, 3.46f, 8.83f);
        }
        else if (cleanLevel > 15)
        {
            //transform.position = new Vector3(-1.0795f, 3.46f, 8.83f);
            transform.localPosition = new Vector3(-0.1548f, 0.03f, 0.0775f);
            anim.SetInteger("Clean Level", 19);
        }
        else if (cleanLevel > 10)
        {
            //transform.position = new Vector3(-0.653f, 3.46f, 8.83f);
            transform.localPosition = new Vector3(-0.0942f, 0.03f, 0.0775f);
            anim.SetInteger("Clean Level", 19);
        }
        else if (cleanLevel > 5)
        {
            anim.SetInteger("Clean Level", 19);
            transform.localPosition = new Vector3(-0.0336f, 0.03f, 0.0775f);
            //transform.position = new Vector3(-0.2265f, 3.46f, 8.83f);
        }
        else if (cleanLevel > 0)
        {
            anim.SetInteger("Clean Level", 19);
            transform.localPosition = new Vector3(0f, 0.03f, 0.0775f);
            //transform.position = new Vector3(0.1f, 3.46f, 8.83f);
        }
        else if (cleanLevel <= 0)
        {
            SceneManager.LoadScene("GameOver");
        }

    }
}
