using UnityEngine;
using System.Collections;

public class Sortir : MonoBehaviour
{
    Canvas canvas;

    void Start()
    {
        canvas = GetComponent<Canvas>();
        canvas.enabled = false;
    }
    public void Quit()
    {
        Application.Quit();
    }
}
