using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelecionUnica : MonoBehaviour
{
    public static SelecionUnica Instance;
    [SerializeField] private GameObject[] objetosEliminar;
    [SerializeField] private GameObject[] Retros;
    public int medallas;

    public void respuestaCorrecta()
    {
        medallas++;
        Retros[0].SetActive(true);
    }
    public void respuestaIncorrecta()
    {
        Retros[1].SetActive(true);
    }

    public void salirPanel()
    {
        Time.timeScale = 1;
        objetosEliminar[0].SetActive(false);
        objetosEliminar[1].SetActive(false);
    }
}
