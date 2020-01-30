using UnityEngine;
using System.Collections;

public class Generador3 : MonoBehaviour {
	public GameObject[] objecte;

    void Start()
    {
        Generar();
    }

    void Generar()
    {
        Instantiate(objecte[Random.Range(0, objecte.Length)], transform.position, Quaternion.Euler(0f, 0f, 0f));
    }
}

