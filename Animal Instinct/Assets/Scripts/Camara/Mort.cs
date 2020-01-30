using UnityEngine;
using System.Collections;

public class Mort : MonoBehaviour {
	public GameObject Camara;
	public GameObject A;
	public GameObject B;
	public GameObject C;
	public GameObject D;
	public GameObject E;
    public GameObject F;
    public GameObject G;
	public AudioClip Res;


	// Use this for initialization
	void Start () {
		NotificationCenter.DefaultCenter().AddObserver (this ,"Personatgehamort");
	}
	
	// Update is called once per frame
	void Personatgehamort (Notification Notificacio) {
        Camara.SetActive (true);
        A.SetActive (false);
		B.SetActive (false);
		C.SetActive (false);
		D.SetActive (false);
		E.SetActive (false);
		F.SetActive (false);
        G.SetActive(false);
        GetComponent<AudioSource>().clip = Res;
	}
}
