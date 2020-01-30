using UnityEngine;
using System.Collections;

public class MarcadorPunts : MonoBehaviour {
	public GameObject NewRecord;
    private int key = 0;
    private int _puntuacio = 0;
    public int puntuacio
    {
        get { return _puntuacio ^ key; }
        set
        {
            key = Random.Range(0, int.MaxValue);
            _puntuacio = value ^ key;
        }
    }
  
    public TextMesh Marcador;
	public TextMesh Marcador2;
	public TextMesh Record;
	public TextMesh Record2;
	
	// Use this for initialization
	void Update () {
		NotificationCenter.DefaultCenter().AddObserver(this, "IncrementarPunts");
		NotificationCenter.DefaultCenter().AddObserver (this ,"Personatgehamort");
		ActualitzarMarcador();
	}
	void Personatgehamort(Notification notificacio){
		if (puntuacio > Inmortal.inmortal.puntuacioMaxima) {
			Inmortal.inmortal.puntuacioMaxima = puntuacio;
			Inmortal.inmortal.Guardar ();
			NewRecord.SetActive (true);
			Record2.text = puntuacio.ToString ();
		} else {
			Record2.text = Inmortal.inmortal.puntuacioMaxima.ToString ();
		}
    }
	void IncrementarPunts(Notification notificacio){
		int puntsAIncrementar = (int)notificacio.data;
		puntuacio+=puntsAIncrementar;
		ActualitzarMarcador();
	}
	void ActualitzarMarcador (){
		Marcador.text = puntuacio.ToString ();
		Marcador2.text = puntuacio.ToString ();
		Record.text = Inmortal.inmortal.puntuacioMaxima.ToString ();
	}
}