using UnityEngine;
using System.Collections;

public class Esquerra : MonoBehaviour {
    private float Posicio = 2f;
    public static Esquerra Esque;
    public Rigidbody rb;
    private float velocitat = Random.Range(150000f, 710000f);
    public float temps = 10f;
    // Use this for initialization
    void Start()
    {
        rb.position = new Vector3(rb.position.x, Posicio, rb.position.z);
    }
    void Update()
    {
        rb.AddForce(velocitat, 0, 0);
        rb.mass = 100000;
        Destroy();
    }
    void Destroy() { StartCoroutine(Begin()); }

    IEnumerator Begin()
    {
        yield return new WaitForSeconds(temps);
        Destroy(gameObject);
    }
}
