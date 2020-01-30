using UnityEngine;
using System.Collections;

public class Destructor4 : MonoBehaviour {

	void OnTriggerEnter(Collider other){
		if(other.tag == "Generats" +"Contenidor" +"Cotxe"){
			Destroy(other.gameObject);
		}
	}
}
