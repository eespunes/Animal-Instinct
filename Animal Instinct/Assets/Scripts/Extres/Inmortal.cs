using UnityEngine;
using System.Collections;
using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using GooglePlayGames;
using UnityEngine.SocialPlatforms;

public class Inmortal : MonoBehaviour {

	public int puntuacioMaxima = 0;
	public int puntuaciomoneMaxima = 0;
    public int Increment = 0;
	public int idioma=0;
	public static Inmortal inmortal;
	
	private String rutaArchiu;

	public string textos(int x, string a,string b, string c){
		switch (x) {
		case 0:
			return a;
			break;
		case 1:
			return b;
			break;
		case 2:
			return c;
			break;
		default:
			return "";
		}
	}
	void Awake(){
		rutaArchiu = Application.persistentDataPath + "/data.dat";
		if(inmortal==null){
			inmortal = this;
			DontDestroyOnLoad(gameObject);
            PlayGamesPlatform.Activate();
		}else if(inmortal!=this){
			Destroy(gameObject);
		}
	}

	void Start () {
		Carregar();
        ((PlayGamesPlatform)Social.Active).Authenticate((bool success) => { }, true);
        string[] testDeviceIDs = new string[] { "2B9F1BDC694BDEBED5847139CF67C5E3" };
        EasyGoogleMobileAds.GetInterstitialManager().SetTestDevices(true, testDeviceIDs);
        EasyGoogleMobileAds.GetInterstitialManager().PrepareInterstitial("ca-app-pub-9639282647804237/1871858105");
    }
	
	public void Guardar(){
		BinaryFormatter bf = new BinaryFormatter();
		FileStream file = File.Create(rutaArchiu);
		
		DadesAGuardar dades = new DadesAGuardar();
		DadesAGuardar dades3 = new DadesAGuardar();
        DadesAGuardar dades2 = new DadesAGuardar();
		DadesAGuardar dades4 = new DadesAGuardar();
        dades.puntuacioMaxima = puntuacioMaxima;
		dades3.puntuaciomoneMaxima += puntuaciomoneMaxima;
        dades2.Increment += Increment;
		dades4.idioma = idioma;

        //Ranking
        Social.ReportScore(puntuacioMaxima, "CgkI19XKzYANEAIQCQ", (bool success) => { });
        //Medalles
        if (puntuacioMaxima >= 25)
        {
            Social.ReportProgress("CgkI19XKzYANEAIQAQ", 100.0, (bool success) => { });
        }
        if (puntuacioMaxima >= 75)
        {
            Social.ReportProgress("CgkI19XKzYANEAIQAg", 100.0, (bool success) => { });
        }
        if (puntuacioMaxima >= 150)
        {
            Social.ReportProgress("CgkI19XKzYANEAIQAw", 100.0, (bool success) => { });
        }
        if (puntuacioMaxima >= 250)
        {
            Social.ReportProgress("CgkI19XKzYANEAIQBA", 100.0, (bool success) => { });
        }
        if (puntuacioMaxima >= 500)
        {
            Social.ReportProgress("CgkI19XKzYANEAIQCg", 100.0, (bool success) => { });
        }
        if (puntuacioMaxima >= 1000)
        {
            Social.ReportProgress("CgkI19XKzYANEAIQBQ", 100.0, (bool success) => { });
        }
        if (puntuaciomoneMaxima >= 5000)
        {
            Social.ReportProgress("CgkI19XKzYANEAIQBw", 100.0, (bool success) => { });
        }

        bf.Serialize(file, dades);
		bf.Serialize(file, dades3);
        bf.Serialize(file, dades2);
		bf.Serialize(file, dades4);

        file.Close();
	}
	
	public void Carregar(){
			BinaryFormatter bf = new BinaryFormatter();
			FileStream file = File.Open(rutaArchiu, FileMode.Open);
			
			DadesAGuardar dades = (DadesAGuardar) bf.Deserialize(file);
			DadesAGuardar dades3 = (DadesAGuardar) bf.Deserialize(file);
            DadesAGuardar dades2 = (DadesAGuardar)bf.Deserialize(file);
			DadesAGuardar dades4 = (DadesAGuardar)bf.Deserialize(file);

            puntuacioMaxima = dades.puntuacioMaxima;
			puntuaciomoneMaxima += dades3.puntuaciomoneMaxima;
            Increment += dades2.Increment;
		idioma = dades4.idioma;
        //Ranking
        Social.ReportScore(puntuacioMaxima, "CgkI19XKzYANEAIQCQ", (bool success) => { });
        //Medalles
        if (puntuacioMaxima >= 25)
        {
            Social.ReportProgress("CgkI19XKzYANEAIQAQ", 100.0, (bool success) => { });
        }
        if (puntuacioMaxima >= 75)
        {
            Social.ReportProgress("CgkI19XKzYANEAIQAg", 100.0, (bool success) => { });
        }
        if (puntuacioMaxima >= 150)
        {
            Social.ReportProgress("CgkI19XKzYANEAIQAw", 100.0, (bool success) => { });
        }
        if (puntuacioMaxima >= 250)
        {
            Social.ReportProgress("CgkI19XKzYANEAIQBA", 100.0, (bool success) => { });
        }
        if (puntuacioMaxima >= 500)
        {
            Social.ReportProgress("CgkI19XKzYANEAIQCg", 100.0, (bool success) => { });
        }
        if (puntuacioMaxima >= 1000)
        {
            Social.ReportProgress("CgkI19XKzYANEAIQBQ", 100.0, (bool success) => { });
        }
        if (puntuaciomoneMaxima >= 5000)
        {
            Social.ReportProgress("CgkI19XKzYANEAIQBw", 100.0, (bool success) => { });
        }

        file.Close();
	}
}

[Serializable]
class DadesAGuardar{
	public int puntuacioMaxima;
    public int puntuaciomoneMaxima;
    public int Increment;
	public int idioma;
}

