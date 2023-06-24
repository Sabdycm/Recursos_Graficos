using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeVida : MonoBehaviour
{
    [SerializeField] private float tiempoVida;

    private void Start()
    {
        Destroy(gameObject, tiempoVida);
    }
}
