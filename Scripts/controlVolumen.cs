using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class controlVolumen : MonoBehaviour
{
    public Slider ControlVolumen;

    public AudioSource audios;

    private void Start()
    {
        ControlVolumen.value = PlayerPrefs.GetFloat("volumenSave");
    }
    public void guardarVolumen()
    {
        PlayerPrefs.SetFloat("volumenSave", ControlVolumen.value);
    }
}
