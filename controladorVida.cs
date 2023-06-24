using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class controladorVida : MonoBehaviour
{
    [SerializeField] private GameObject[] corazones;
    private int contador;
    [SerializeField] private GameObject ActivarMuerte;

    private void Start()
    {
        ActivarMuerte.SetActive(false);
        contador = corazones.Length;
    }

    private void Update()
    {
        if(contador < 1)
        {
            ActivarMuerte.SetActive(true);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            contador--;
            Destroy(corazones[contador]);
        }
    }
    private void reanudar()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
