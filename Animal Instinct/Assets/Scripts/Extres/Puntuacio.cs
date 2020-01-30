using UnityEngine;
using System.Collections;

public class Puntuacio : MonoBehaviour {
	
	public int puntsGuanyats = 1;

	void OnTriggerEnter (Collider other){
		if (other.tag == "Player") {
			NotificationCenter.DefaultCenter ().PostNotification (this, "IncrementarPunts", puntsGuanyats);
		}
	}
}
