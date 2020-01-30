using UnityEngine;
using System.Collections;

public class Color : MonoBehaviour {

    public Material colorinicial;
    // Use this for initialization
    void Start () {
        gameObject.GetComponent<Renderer>().material = colorinicial;
        colorinicial.color = new UnityEngine.Color(Random.value, Random.value, Random.value);
    }

}
