using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniyEngine.SceneManagement;

public class ChangeSceneWithButton : MonoBehaviour
{
    public void onstartbuttonclick() 
    {
        SceneManager.LoadScene(mainLevel);
    }
}
