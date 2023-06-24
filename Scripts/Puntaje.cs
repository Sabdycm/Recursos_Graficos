using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Puntaje : MonoBehaviour
{
    private float puntos;

    private TextMeshProUGUI TextMesh;

    private void Start()
    {
        TextMesh = GetComponent<TextMeshProUGUI>();

    }
    public void sumarPuntos(float puntosEntrada)
    {
        puntos += puntosEntrada;
        TextMesh.text = puntos.ToString("0");
    }
}
