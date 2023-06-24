using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using System;

public class contador : MonoBehaviour
{
    private int Contador = 90;
    private float tiempoRetraso = 1.0f;
    private float tiempoUltimaActualizacion = 0.0f;

    [SerializeField] private AudioClip contraReloj;

    [SerializeField] private GameObject canvas;
    public TextMeshProUGUI Puntaje;

    int n;


    public TextMeshProUGUI textoContador;

    void Update()
    {
        if (Time.time - tiempoUltimaActualizacion >= tiempoRetraso)
        {
            ActualizarContador();
            tiempoUltimaActualizacion = Time.time;
        }
    }

    public void ActualizarContador()
    {
        Contador--;
        textoContador.text = Contador.ToString();
        if (textoContador.text == "15")
        {
            textoContador.color = Color.red;
            ControladorSonido.Instance.reproducirSonido(contraReloj);
        }
        else if (textoContador.text == "0")
        {
            canvas.SetActive(true);
        }
        if(Convert.ToInt32(textoContador.text) < 60)
        {
            Puntaje.text = "Tu puntaje es de 70 pts devido al tiempo que tardaste en contestar";
        }
        else if (Convert.ToInt32(textoContador.text) < 21)
        {
            Puntaje.text = "Tu puntaje es de 50 pts devido al tiempo que tardaste en contestar";
        }
        else if(Convert.ToInt32(textoContador.text) > 60)
        {
            Puntaje.text = "Tu puntaje es de 100 pts, ¡Felicidades!";
        }
    }
    public void reintentar()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
