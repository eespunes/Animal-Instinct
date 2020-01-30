using UnityEngine;
using System.Collections;

public class DestructorCarrer : MonoBehaviour
{
    private float temps = 13f;
    public static DestructorCarrer Destru;
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
}