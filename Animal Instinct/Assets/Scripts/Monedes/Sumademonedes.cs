using UnityEngine;
using System.Collections;

public class Sumademonedes : MonoBehaviour {
    public int MonedesGuanyades = 1;
	public GameObject Mon1;
    
	public float a = 1f;
    void Update () {
		transform.Rotate(new Vector3(a, 0, 0));
	}
	
	void OnTriggerEnter (Collider other){
		if (other.tag == "Player") {
			NotificationCenter.DefaultCenter ().PostNotification (this, "IncrementarMonedes", MonedesGuanyades);
        }
	}
}
