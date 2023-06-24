using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class llegaPlanetaInicio : MonoBehaviour
{
    [SerializeField] private GameObject desactivarPlanetDesc;
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.CompareTag("tierra"))
        {
            desactivarPlanetDesc.SetActive(false);
        }
    }
}
