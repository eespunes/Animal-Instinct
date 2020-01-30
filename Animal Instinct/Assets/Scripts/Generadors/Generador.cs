using UnityEngine;
using System.Collections;

public class Generador : MonoBehaviour {

	public GameObject[] objecte;
	
	void OnTriggerEnter (Collider other){
		if (other.tag == "Player") {
			Generar ();
		}
	}
	void Generar () {
		Instantiate(objecte[Random.Range (0,objecte.Length)], transform.position, Quaternion.Euler(0f,0f,0f));
	}
}
