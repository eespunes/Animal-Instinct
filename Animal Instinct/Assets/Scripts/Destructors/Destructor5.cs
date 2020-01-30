using UnityEngine;
using System.Collections;

public class Destructor5 : MonoBehaviour {
	public AudioClip Coin;	
	void OnTriggerEnter(Collider other){
		if(other.tag == "€"){
			Destroy(other.gameObject);
			GetComponent<AudioSource>().clip = Coin;
			GetComponent<AudioSource>().Play();
		}
	}
}
