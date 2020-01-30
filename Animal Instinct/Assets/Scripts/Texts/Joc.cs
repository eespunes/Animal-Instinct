using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Joc : MonoBehaviour {
	
	public TextMesh punts, puntsM,record,recordM,nouRec,mort,mon,monTot;
	public Text start,cont,musica,fx,jugar,canv;
	string aS,bs,cs,ap,bp,cp,ar,am,bm,af,bf,cf,ac,bc,cc,an,bn,cn,ad,bd,cd,amo,bmo,cmo,amt,bmt,cmt,aj,bj,cj,aca,bca,cca;

	void Update () {
		aS = "Tap to\nplay";
		bs = "Toca para\njugar";
		cs = "Toca per\njugar";
		start.text = Inmortal.inmortal.textos (Inmortal.inmortal.idioma, aS, bs, cs);

		ap = "Score:";
		bp = "puntos:";
		cp = "punts:";
		punts.text = Inmortal.inmortal.textos (Inmortal.inmortal.idioma, ap, bp, cp);
		puntsM.text = Inmortal.inmortal.textos (Inmortal.inmortal.idioma, ap, bp, cp);

		ar = "Record:";
		record.text = Inmortal.inmortal.textos (Inmortal.inmortal.idioma, ar, ar, ar);
		recordM.text = Inmortal.inmortal.textos (Inmortal.inmortal.idioma, ar, ar, ar);

		am = "Music";
		bm = "Musica";
		musica.text = Inmortal.inmortal.textos (Inmortal.inmortal.idioma, am, bm, bm);

		af = "Sound effects";
		bf = "Efectos de sonido";
		cf = "Efectes de so";
		fx.text = Inmortal.inmortal.textos (Inmortal.inmortal.idioma, af, bf, cf);

		ac = "Resume";
		bc = "Reanudar";
		cc = "Reemprendre";
		cont.text = Inmortal.inmortal.textos (Inmortal.inmortal.idioma, ac, bc, cc);

		an = "New\nRecord!!";
		bn = "¡¡Nuevo\nRecord!!";
		cn = "Nou\nRecord!!";
		nouRec.text = Inmortal.inmortal.textos (Inmortal.inmortal.idioma, an, bn, cn);

		ad = "Game Over";
		bd = "Fin del Juego";
		cd = "Fi del joc";
		mort.text = Inmortal.inmortal.textos (Inmortal.inmortal.idioma, ad, bd, cd);

		amo = "Coins earned";
		bmo= "Monedas ganadas";
		cmo = "Monedes guayades";
		mon.text = Inmortal.inmortal.textos (Inmortal.inmortal.idioma, amo, bmo, cmo);

		amt = "Total coins";
		bmt = "Monedas totales";
		cmt = "Monedes totals";
		monTot.text = Inmortal.inmortal.textos (Inmortal.inmortal.idioma, amt, bmt, cmt);

		aj = "Total coins";
		bj = "Monedas totales";
		cj = "Monedes totals";
		jugar.text = Inmortal.inmortal.textos (Inmortal.inmortal.idioma, aj, bj, cj);

		aca = "Total coins";
		bca = "Monedas totales";
		cca = "Monedes totals";
		canv.text = Inmortal.inmortal.textos (Inmortal.inmortal.idioma, aca, bca, cca);
	}
}
