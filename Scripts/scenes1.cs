using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scenes1 : MonoBehaviour
{

    public void iniciar(int numeroScene)
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(numeroScene);

    }
    public void reiniciar()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void salirJuego()
    {
        Application.Quit();
    }
}
