using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scriptLLegaPlanet : MonoBehaviour
{
    public int numeroScene;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("tierra"))
        {
            SceneManager.LoadScene(numeroScene);
        }
    }
}
