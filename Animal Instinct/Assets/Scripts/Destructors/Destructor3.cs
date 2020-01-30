using UnityEngine;
using System.Collections;

public class Destructor3 : MonoBehaviour {

	void OnTriggerEnter(Collider other){
		if(other.tag != "Carrer"){
			Destroy(other.gameObject);
		}
	}
}
