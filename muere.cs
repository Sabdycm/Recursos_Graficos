using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class muere : MonoBehaviour
{
    [SerializeField] private GameObject muertePanel;
    private void OnCollisionEnter2D (Collision2D collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            muertePanel.SetActive(true);
        }
    }
    public void mainMenu(int sceneMainMenu)
    {
        SceneManager.LoadScene(sceneMainMenu);
    }
    public void reintentar()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
