using UnityEngine;
using System.Collections;

public class Sumademonedes2 : MonoBehaviour {
	public int MonedesGuanyades2 = 2;
    public GameObject Mon2;
    public float a = -1f;
    void Update () {
		transform.Rotate(new Vector3(a, 0, 0));
	}
	void OnTriggerEnter (Collider other){
		if (other.tag == "Player") {
			NotificationCenter.DefaultCenter ().PostNotification (this, "IncrementarMonedes", MonedesGuanyades2);
        }
	}
}
