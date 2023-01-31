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
        GameObject[] enemies = GameObject.FindGameObjectsWithTag("LizzyEnemy");
        
        enemies1 = enemies.Length;

        enemies2 = enemies1 * 5;
        cleanLevel = cleanLevel1 - enemies2;

        if (cleanLevel > 100)
        {
            SceneManager.LoadScene("TitleScreenScene");
        }
        else if (cleanLevel > 90)
        {
            transform.position = new Vector3(-8.25f, 3.46f, 8.83f);
            anim.SetInteger("Clean Level", 81);
        }
        else if (cleanLevel > 80)
        {
            anim.SetInteger("Clean Level", 81);
            transform.position = new Vector3(-6.9f, 3.46f, 8.83f);
        }
        else if (cleanLevel > 70)
        {
            transform.position = new Vector3(-5.2f, 3.46f, 8.83f);
            anim.SetInteger("Clean Level", 51);
        }
        else if (cleanLevel > 60)
        {
            transform.position = new Vector3(-4f, 3.46f, 8.83f);
            anim.SetInteger("Clean Level", 51);
        }
        else if (cleanLevel > 50)
        {
            anim.SetInteger("Clean Level", 51);
            transform.position = new Vector3(-3.5f, 3.46f, 8.83f);
        }
        else if (cleanLevel > 40)
        {
            transform.position = new Vector3(-2.6f, 3.46f, 8.83f);
            anim.SetInteger("Clean Level", 21);
        }
        else if (cleanLevel > 30)
        {
            transform.position = new Vector3(-1.9f, 3.46f, 8.83f);
            anim.SetInteger("Clean Level", 21);
        }
        else if (cleanLevel > 20)
        {
            anim.SetInteger("Clean Level", 21);
            transform.position = new Vector3(-1.3f, 3.46f, 8.83f);
        }
        else if (cleanLevel > 10)
        {
            transform.position = new Vector3(-0.5f, 3.46f, 8.83f);
            anim.SetInteger("Clean Level", 19);
        }
        else if (cleanLevel > 0)
        {
            anim.SetInteger("Clean Level", 19);
            transform.position = new Vector3(0f, 3.46f, 8.83f);
        }
        else if (cleanLevel <= 0)
        {
            SceneManager.LoadScene("TitleScreenScene");
        }

        
    }

    

    //public void barmoveenemyspawn()
    //{
        //bar.transform.position += new Vector3(0.437f, 0, 0);
    //}
    //public void barmovedestroy()
    //{
        //bar.transform.position -= new Vector3(0.437f, 0, 0);
    //}
}
