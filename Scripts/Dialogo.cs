using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Dialogo : MonoBehaviour
{
    [SerializeField] float TiempoEscribir;
    [SerializeField] GameObject panelDialogo;
    [SerializeField] TextMeshProUGUI dialogoText;
    [SerializeField, TextArea(4, 6)] private string[] dialogoLineas;

    private bool dialogoStart;
    private int lineIndex;
    private BoxCollider2D b;

    private void nuevaLineaDialogo()
    {
        lineIndex++;
        if (lineIndex < dialogoLineas.Length)
        {
            StartCoroutine(VistaLinea());
            
        }
        else
        {
            dialogoStart = false;
            panelDialogo.SetActive(false);
        }
    }
    public void saltarD()
    {
        if (dialogoText.text == dialogoLineas[lineIndex])
        {
            Time.timeScale = 1;
            nuevaLineaDialogo();
        } else
        {
            Time.timeScale = 1;
            StopAllCoroutines();
            
            dialogoText.text = dialogoLineas[lineIndex];

        }

    }
    private void startDialogo()
    {
        dialogoStart = true;
        panelDialogo.SetActive(true);
        lineIndex = 0;
        StartCoroutine(VistaLinea());
    }

    private IEnumerator VistaLinea()
    {
        
        dialogoText.text = string.Empty;
        foreach (char ch in dialogoLineas[lineIndex])
        {

            dialogoText.text += ch;
            yield return new WaitForSecondsRealtime(TiempoEscribir);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Time.timeScale = 0;
            if (!dialogoStart)
            {
                startDialogo();

            }
        }

    }
    public void TextIniciar()
    {
        Time.timeScale = 0;
        if (!dialogoStart)
        {
            startDialogo();

        }
    }
}
