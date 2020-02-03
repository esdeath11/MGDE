using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    public static bool GamePause = false;
    public GameObject PauseUi;


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GamePause)
            {
                resume();
            }
            else
            {
                pause();
            }
        }
    }

    public void resume()
    {
        PauseUi.SetActive(false);
        Time.timeScale = 1f;
        GamePause = false;
    }

    void pause()
    {
        PauseUi.SetActive(true);
        Time.timeScale = 0f;
        GamePause = true;
    }


}
