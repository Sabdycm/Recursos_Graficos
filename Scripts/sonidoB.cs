using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sonidoB : MonoBehaviour
{
    public AudioSource fuente;
    public AudioClip clip;

     void Start() 
    {
         fuente.clip= clip;
    }
    public void reproducir()
    {
        fuente.Play();
    }
}
