using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasMainMenu : MonoBehaviour
{
    [SerializeField] private GameObject[] canvasMainMenu;
    public void mainMenu(GameObject activado)
    {
        canvasMainMenu[0].SetActive(false);
        canvasMainMenu[1].SetActive(false);
        canvasMainMenu[2].SetActive(false);
        activado.SetActive(true);
    }
}
