using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemigo : MonoBehaviour
{
    [SerializeField] private float vida;
    [SerializeField] private GameObject efectoMuerte;

    [SerializeField] private AudioClip dolor;

    public void tomarDaño(float daño)
    {
        vida = vida - daño;
        if(vida <= 0)
        {
            muerte();
        }
    }

    private void muerte()
    {
        ControladorSonido.Instance.reproducirSonido(dolor);
        Instantiate(efectoMuerte, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}
