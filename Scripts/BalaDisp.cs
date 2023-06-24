using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalaDisp : MonoBehaviour
{
    [SerializeField] private float velocidad;
    [SerializeField] private float daño;
    private Rigidbody2D rb;
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        transform.Translate(Vector2.right * velocidad * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("enemigo"))
        {
            collision.GetComponent<Enemigo>().tomarDaño(daño);
            Destroy(gameObject);
        }
    }
}
