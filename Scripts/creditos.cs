using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class creditos : MonoBehaviour
{
    public float velocidady = 1.81f;
    public float posY = -76.48694f;

    private void Update()
    {
        transform.Translate(0,velocidady * Time.deltaTime, 0);

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("creditos"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
