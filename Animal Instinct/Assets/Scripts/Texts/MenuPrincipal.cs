using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuPrincipal : MonoBehaviour {
	public int consegueix;
	public TextMesh pers,sort,tut1,cons;
	string ap,bp,cp,aS,bs,cs,at,ac,bc,cc;

	void Update () {
		ap = "Character\nSelection";
		bp = "Seleccionar\npersonaje";
		cp = "Seleccionar\npersonatge";
		pers.text = Inmortal.inmortal.textos (Inmortal.inmortal.idioma, ap, bp, cp);

		aS = "Exit";
		bs = "Salir";
		cs = "Sortir";
		sort.text = Inmortal.inmortal.textos (Inmortal.inmortal.idioma, aS, bs, cs);

		at = "Tutorial";
		tut1.text = Inmortal.inmortal.textos (Inmortal.inmortal.idioma, at, at, at);

		ac = "Earn\n"+consegueix;
		bc = "Consigue\n"+consegueix;
		cc = "Consegueix\n"+consegueix;
		cons.text = Inmortal.inmortal.textos (Inmortal.inmortal.idioma, ac, bc, cc);
	}
}
