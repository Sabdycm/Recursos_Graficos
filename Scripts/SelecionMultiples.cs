using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System;

public class SeleccionMultiples : MonoBehaviour
{
    [SerializeField] private GameObject preguntas;
    [SerializeField] private GameObject[] retro;

    [SerializeField] private int[] resultadosN;

    [SerializeField] private TMP_InputField[] resultados;


    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            preguntas.SetActive(true);
            Time.timeScale = 0;
        }
    }
    public void comprobar()
    {
        int s1 = Convert.ToInt32(resultados[0].text);
        int s2 = Convert.ToInt32(resultados[1].text);

        if (s1 == resultadosN[0] && s2 == resultadosN[1])
        {
            retro[0].SetActive(true);
        }
        else
        {
            retro[1].SetActive(true);
        }
    }
    public void salirRetro(GameObject s1)
    {
        Time.timeScale = 1;
        Destroy(gameObject);
        Destroy(s1);
    }
}
