using UnityEngine;
using System.Collections;

public class Generador4 : MonoBehaviour {

	public GameObject[] objecte;
	public GameObject[] objecte2;
	public float a=0f;
	

	public void OnTriggerEnter (Collider other){
		if (other.tag == "Player") {
				Instantiate(objecte[Random.Range (0,objecte.Length)], transform.position, Quaternion.Euler(0f,a,0f));
		}
	}
}