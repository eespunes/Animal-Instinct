using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarregarText : MonoBehaviour {

	public TextMesh carr;
	string ac,bc,cc;

	void Update () {
		ac = "Loading";
		bc = "Cargando";
		cc = "Carregant";
		carr.text = Inmortal.inmortal.textos (Inmortal.inmortal.idioma, ac, bc, cc);
	}
}
