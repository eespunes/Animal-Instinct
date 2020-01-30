using UnityEngine;
using System.Collections;

public class Marcadormonedes : MonoBehaviour {
    private int key = 0;
    private int _puntuaciomon = 0;
    public int puntuaciomon
    {
        get { return _puntuaciomon ^ key; }
        set
        {
            key = Random.Range(0, int.MaxValue);
            _puntuaciomon = value ^ key;
        }
    }
    public TextMesh Marcador;
	public TextMesh Marcador2;
	public TextMesh MonTot;
	public TextMesh MonTot2;
	
	// Use this for initialization
	void Start () {
		NotificationCenter.DefaultCenter().AddObserver(this, "IncrementarMonedes");
		NotificationCenter.DefaultCenter().AddObserver (this ,"Personatgehamort");
		ActualitzarMarcador ();
    }
    void Update()
    {
        ActualitzarMarcador();
    }
	void Personatgehamort(Notification notificacio){
     /* if (puntuaciomon == (1||4 || 7 || 10 || 13 || 16 || 19 || 22 || 25 || 28 || 31 || 34 || 37 || 40 || 43 || 46 || 49 || 52 || 55 || 58 || 61 || 64 || 67 || 70 || 73 || 76 || 79 || 82 || 85 || 88 || 91 || 94 || 97 || 100){
             Inmortal.inmortal.puntuaciomoneMaxima = (puntuaciomon / 3 + Inmortal.inmortal.puntuaciomoneMaxima);
        }*/
        Inmortal.inmortal.puntuaciomoneMaxima = (puntuaciomon / 3 + Inmortal.inmortal.puntuaciomoneMaxima);
			Inmortal.inmortal.Guardar();
			MonTot2.text = puntuaciomon.ToString ();
			MonTot2.text = Inmortal.inmortal.puntuaciomoneMaxima.ToString ();
       
    }
	void IncrementarMonedes(Notification notificacio){
		int puntsAIncrementarmon = (int)notificacio.data;
			puntuaciomon += puntsAIncrementarmon;
		ActualitzarMarcador();
	}
	void ActualitzarMarcador (){
		Marcador.text = puntuaciomon.ToString ();
		Marcador2.text = puntuaciomon.ToString ();
		MonTot.text=Inmortal.inmortal.puntuaciomoneMaxima.ToString ();


        ;
        ;
	}
}