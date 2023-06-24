using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bala : MonoBehaviour
{
    [SerializeField] private Transform controladorDispara;

    [SerializeField] private GameObject Balas;
    public AudioClip disparo;

    private void Update()
    {
    }
    public void disparar()
    {
        ControladorSonido.Instance.reproducirSonido(disparo);
        Instantiate(Balas, controladorDispara.position, controladorDispara.rotation);
    }
}
