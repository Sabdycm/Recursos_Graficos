using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class habilitarPreguntasSuma : MonoBehaviour
{
    [SerializeField] private GameObject Presentacion;
    [SerializeField] private GameObject prese;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Presentacion.SetActive(true);
            Time.timeScale = 0;
        }
    }
    public void salirPanel(GameObject presentacion)
    {
        Time.timeScale = 1;
        Destroy(gameObject);
        Destroy(presentacion);
        Destroy(prese);
    }


}
