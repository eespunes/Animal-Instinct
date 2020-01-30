using UnityEngine;
using System.Collections;

public class Destructor6 : MonoBehaviour {

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "€")
        {
            Destroy(other.gameObject);
        }
    }
}
