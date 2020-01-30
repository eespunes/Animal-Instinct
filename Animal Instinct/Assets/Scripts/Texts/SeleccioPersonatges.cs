using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SeleccioPersonatges : MonoBehaviour {

	public TextMesh noMon, siMon;
	public Text comp,jug,torn,si,no;
	string ac,bc,aj,bj,at,bt,ct,anm,bnm,cnm,aS,bs,an,asn,bsn,csn;

	void Update () {
		ac = "Buy";
		bc = "Comprar";
		comp.text = Inmortal.inmortal.textos (Inmortal.inmortal.idioma, ac, bc, bc);

		aj = "Play";
		bj = "Jugar";
		jug.text = Inmortal.inmortal.textos (Inmortal.inmortal.idioma, aj, bj, bj);

		at = "Return";
		bt = "Volver";
		ct = "Tornar";
		torn.text = Inmortal.inmortal.textos (Inmortal.inmortal.idioma, at, bt, ct);

		anm = "You don't have\nenough money!!";
		bnm = "¡¡No tienes\nsuficiente dinero!!";
		cnm = "No tiens\nsuficients diners!!";
		noMon.text = Inmortal.inmortal.textos (Inmortal.inmortal.idioma, anm, bnm, cnm);

		asn = "Do yoy want to spent";
		bsn = "¿Quieres gastar";
		csn = "Vols gastar-te";
		siMon.text = Inmortal.inmortal.textos (Inmortal.inmortal.idioma, asn, bsn, csn);

		aS = "Yes";
		bs = "Si";
		si.text = Inmortal.inmortal.textos (Inmortal.inmortal.idioma, aS, bs, bs);

		an = "NO";
		no.text = Inmortal.inmortal.textos (Inmortal.inmortal.idioma, an, an, an);

	}
}