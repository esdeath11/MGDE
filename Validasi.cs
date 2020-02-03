using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Validasi : MonoBehaviour
{
    public GameObject validasi;
    public GameObject Mainmenu;

    public void Exit()
    {
        validasi.SetActive(true);
        Mainmenu.SetActive(false);
        Application.Quit();
    }

    public void noQuit()
    {
        validasi.SetActive(false);
        Mainmenu.SetActive(true);
    }

}
