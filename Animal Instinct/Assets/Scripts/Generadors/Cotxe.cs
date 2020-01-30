using UnityEngine;
using System.Collections;

public class Cotxe : MonoBehaviour {
	private float Posicio = 2f;
	public Rigidbody rb;
	// Use this for initialization
	void Update () {
		rb.position = new Vector3 (rb.position.x, Posicio, rb.position.z);
        transform.rotation = Quaternion.Euler(0f, 90f, 0f);
    }
}