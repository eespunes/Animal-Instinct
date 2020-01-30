using UnityEngine;
using System.Collections;

public class Destructor2 : MonoBehaviour {
    public static Destructor2 Destruct;
    public float temps = 5f;
    void Start()
    {
        Destroy();
    }

    void Destroy() { StartCoroutine(Begin()); }

    IEnumerator Begin()
    {
        yield return new WaitForSeconds(temps);
        Destroy(gameObject);
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            NotificationCenter.DefaultCenter().PostNotification(this, "Personatgehamort");
            GameObject persontge = GameObject.Find("Gat");
            persontge.SetActive(false);
        }
    }
}
