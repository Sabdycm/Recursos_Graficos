    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;
    using UnityEngine.SceneManagement;
using UnityEngine.UI;

    public class movi : MonoBehaviour
    {
        public float speedMov;
        private bool movIzq;
        private bool movDere;
        private bool up;
        public float jumpForce;
        public bool isGrounded;
        public Button btn;
    public AudioClip  saltar;


        public Animator Animator;
        public Rigidbody2D rb2D;

    public GameObject irTierra;
    public void energíaMas()
    {
        speedMov += (speedMov * 50) / 100;

        btn.enabled = false;
        ColorBlock colors = btn.colors;
        colors.normalColor = Color.gray;
        btn.colors = colors;
    }

        public void btnIzquierda ()
        {
            movIzq = true;
            Animator.SetBool("running", true);
        }
        public void btnNoIzquierda()
        {
            movIzq = false;
            Animator.SetBool("running", false);
    }
        public void btnDerecha()
        {
            movDere = true;
        Animator.SetBool("running", true);
        }
        public void btnNoDerecha()
        {
            movDere = false;
        Animator.SetBool("running", false);
        }
    public void btnJump()
    {
        up = true;
        ControladorSonido.Instance.reproducirSonido(saltar);
    }

        public void Update()
        {
            if (movIzq)
            {
                transform.Translate(Vector3.left * speedMov * Time.deltaTime);
                transform.localScale = new Vector3(-1.0f, 1.0f, 1.0f);
        }
            else if (movDere)
            {
                transform.Translate(Vector3.right * speedMov * Time.deltaTime);
                transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
        }   
            if(up && isGrounded)
            {
                up = false;
                rb2D.AddForce(new Vector2(0, jumpForce));
            }

        }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("pasa")){
            Time.timeScale = 1;
            irTierra.SetActive(true);
        }
        

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("suelo"))
        {
            isGrounded = true;
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("suelo"))
        {
            isGrounded = false;
        }
    }
}
