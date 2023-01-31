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
    public int cleanLevel1 = 50;
    public GameObject bar;

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

        enemies2 = enemies1 * 4;
        cleanLevel = cleanLevel1 - enemies2;

        if (cleanLevel > 80)
        {
            anim.SetInteger("Clean Level", 81);
        }
        else if (cleanLevel > 50)
        {
            anim.SetInteger("Clean Level", 51);
        }
        else if (cleanLevel > 20)
        {
            anim.SetInteger("Clean Level", 21);
            transform.position += new Vector3(0.437f, 0, 0);
        }
        else if (cleanLevel > 0)
        {
            anim.SetInteger("Clean Level", 19);
        }
        else if (cleanLevel == 0)
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
