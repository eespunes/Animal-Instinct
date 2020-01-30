using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tutorial : MonoBehaviour {

	public TextMesh tut;
	string a,b,c;

	void Update () {
		a = "Return";
		b = "Volver";
		c = "Tornar";
		tut.text = Inmortal.inmortal.textos (Inmortal.inmortal.idioma, a, b, c);
	}
}
