using UnityEngine;
using System.Collections;

public class Generador6 : MonoBehaviour {

    public GameObject[] objecte;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Instantiate(objecte[Random.Range(0, objecte.Length)], transform.position, Quaternion.identity);
        }
    }
}
