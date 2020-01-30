using UnityEngine;
using System.Collections;

public class Eliminar : MonoBehaviour {

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            NotificationCenter.DefaultCenter().PostNotification(this, "Personatgehamort");
            GameObject persontge = GameObject.Find("Gat");
            persontge.SetActive(false);
        }
    }
}
