using UnityEngine;
using System.Collections;

public class Moto : MonoBehaviour {
	private float Posicio = 3.021194f;
	public Rigidbody rb;
	// Use this for initialization
	void Update () {
		rb.position = new Vector3 (rb.position.x, Posicio, rb.position.z);
	}
}
