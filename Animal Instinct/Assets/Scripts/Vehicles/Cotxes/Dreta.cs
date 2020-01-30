using System.Collections;
using UnityEngine;

public class Dreta : MonoBehaviour {
    private float Posicio = 2f;
    public Rigidbody rb;
    private float velocitat = Random.Range(-130000f, -660000f);
    public float temps = 10f;
    // Use this for initialization
    void Start()
    {
        rb.position = new Vector3(rb.position.x, Posicio, rb.position.z);

    }
    void Update()
    {
        transform.rotation = Quaternion.Euler(0f, 270f, 0f);
        rb.AddForce(velocitat, 0, 0);
        rb.mass = 100000;
        Destroy();
    }
    void Destroy() { StartCoroutine(Begin()); }

    IEnumerator Begin()
    {
        yield return new WaitForSeconds(Esquerra.Esque.temps);
        Destroy(gameObject);
    }
}

