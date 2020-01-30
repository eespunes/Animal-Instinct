using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Catala : MonoBehaviour {
	int idioma =2;
	public void OnMouseDown(){
		Inmortal.inmortal.Carregar ();
		Debug.Log (Inmortal.inmortal.idioma);
		Inmortal.inmortal.idioma = idioma;
		Inmortal.inmortal.Guardar ();
		Debug.Log (Inmortal.inmortal.idioma);
	}
}
