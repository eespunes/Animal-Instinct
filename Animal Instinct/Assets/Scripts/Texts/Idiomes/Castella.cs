using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Castella : MonoBehaviour {
	int idioma =1;
	public void OnMouseDown(){
		Inmortal.inmortal.Carregar ();
		Debug.Log (Inmortal.inmortal.idioma);
		Inmortal.inmortal.idioma = idioma;
		Inmortal.inmortal.Guardar ();
		Debug.Log (Inmortal.inmortal.idioma);
	}
}
