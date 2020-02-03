using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene : MonoBehaviour
{
    public void sceneLoad()
    {
        SceneManager.LoadScene("Gameplay");
        Time.timeScale = 1f;
    }

    public void mainMenu()
    {
        SceneManager.LoadScene("MainMenu"); 
    }

    public void Help()
    {
        SceneManager.LoadScene("Help");
    }
}

