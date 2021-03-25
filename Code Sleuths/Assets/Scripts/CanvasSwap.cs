using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasSwap : MonoBehaviour
{
    public GameObject firstCanvas;
    public GameObject secondCanvas;


    public void Swap()
    {
        secondCanvas.SetActive(true);
        firstCanvas.SetActive(false);
    }
}
