using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Configuracio : MonoBehaviour {
	public TextMesh torn,mus,fx,idi;
	string at,bt,ct,am,bm,af,bf,cf,ai,bi,ci;

	void Update () {
		at = "Return";
		bt = "Volver";
		ct = "Tornar";
		torn.text = Inmortal.inmortal.textos (Inmortal.inmortal.idioma, at, bt, ct);

		ai = "Change\nlanguage";
		bi = "Cambiar\nidioma";
		ci = "Canviar\nidioma";
		idi.text = Inmortal.inmortal.textos (Inmortal.inmortal.idioma, ai, bi, ci);

		am = "Music";
		bm = "Musica";
		mus.text = Inmortal.inmortal.textos (Inmortal.inmortal.idioma, am, bm, bm);

		af = "Sound Effects";
		bf = "Efectos de sonido";
		cf = "Efectes de so";
		fx.text = Inmortal.inmortal.textos (Inmortal.inmortal.idioma, af, bf, cf);
	}
}
