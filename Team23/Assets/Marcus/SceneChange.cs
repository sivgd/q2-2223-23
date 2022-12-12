using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    public string DestanationScene;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Debug.Log("Switch scene");
            SceneManager.LoadScene("Main Level");
        }

        if (collision.tag == "PlayerMainMenu")
        {
            Debug.Log("Switch scene");
            SceneManager.LoadScene(DestanationScene);
        }
    }
}
