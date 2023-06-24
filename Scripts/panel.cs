using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class panel : MonoBehaviour
{
    public static bool gamep;
    public static bool boolsegurop;

    public GameObject menup, segurop;

    private void start()
    {
        menup.SetActive(false);
        segurop.SetActive(false);
    }



    public void SwithPause()
    {
        if(gamep)
        {
            btnResume();
        }else 
        {
            btnpause();
        }
    }
    public void btnResume()
    {
        menup.SetActive(false);
        Time.timeScale = 1;
        gamep = false;
    }
    public void btnpause()
    {
        menup.SetActive(true);
        Time.timeScale = 0;
        gamep = true;
    }

    public void panel2()
    {
        segurop.SetActive(true);
    }

    public void salirp()
    {
        segurop.SetActive(false);
    }

    public void salirpsi()
    {
        Debug.Log("Se ha salido del juego");
        Application.Quit();
    }
}
