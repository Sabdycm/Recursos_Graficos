using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menuPausa : MonoBehaviour
{
    [SerializeField] private GameObject[] btnPausa;
    public void pausa()
    {
        Time.timeScale = 0f;
        btnPausa[0].SetActive(false);
        btnPausa[1].SetActive(true);
    }
    public void reanurar()
    {
        Time.timeScale = 1;
        btnPausa[0].SetActive(true);
        btnPausa[1].SetActive(false);
    }
    public void Reiniciar()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void salir(int numeroScene)
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(numeroScene);
    }
}
