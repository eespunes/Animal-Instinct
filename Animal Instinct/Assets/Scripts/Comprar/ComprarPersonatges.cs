using UnityEngine;
using System.Collections;

public class ComprarPersonatges : MonoBehaviour {
    private bool unlocked,locked;
    private int puntuacioarest = 0;
    public int puntuaciomon = 0,personatge = 0;//0=GAT1,1=GAT2,2=GAT3,3=GOS1,4=GOS2,5=GOS3,6=GOS4,7=OS,8=PANDA,9=CAVALL,10=ZEBRA,11=HIPO,12=GRIAFA,13=UNICORNI,14=ANDROID
    public TextMesh MonTot2;
    public GameObject Jugar,Desbloquejar;

    public GameObject SiMon;
    public TextMesh Marcador,Marcador2;
    private string unlockedString, lockedString;

    void Start()
    {
        switch (personatge)
        {
            case 0:
                unlockedString = "unlockedGa";
                lockedString = "lockedGa";
                puntuacioarest = 1000;
                break;
            case 1:
                unlockedString = "unlockedGa2";
                lockedString = "lockedGa2";
                puntuacioarest = 1000;
                break;
            case 2:
                unlockedString = "unlockedGa3";
                lockedString = "lockedGa3";
                puntuacioarest = 1000;
                break;
            case 3:
                unlockedString = "unlockedGo";
                lockedString = "lockedGo";
                puntuacioarest = 1000;
                break;
            case 4:
                unlockedString = "unlockedGo2";
                lockedString = "lockedGo2";
                puntuacioarest = 1000;
                break;
            case 5:
                unlockedString = "unlockedGo3";
                lockedString = "lockedGo3";
                puntuacioarest = 1000;
                break;
            case 6:
                unlockedString = "unlockedGo4";
                lockedString = "lockedGo4";
                puntuacioarest = 1000;
                break;
            case 7:
                unlockedString = "unlockedOs";
                lockedString = "lockedOs";
                puntuacioarest = 2500;
                break;
            case 8:
                unlockedString = "unlockedPanda";
                lockedString = "lockedPanda";
                puntuacioarest = 2500;
                break;
            case 9:
                unlockedString = "unlockedCav";
                lockedString = "lockedCav";
                puntuacioarest = 2500;
                break;
            case 10:
                unlockedString = "unlockedZeb";
                lockedString = "lockedZeb";
                puntuacioarest = 2500;
                break;
            case 11:
                unlockedString = "unlockedHipo";
                lockedString = "lockedHipo";
                puntuacioarest = 5000;
                break;
            case 12:
                unlockedString = "unlockedGir";
                lockedString = "lockedGir";
                puntuacioarest = 5000;
                break;
            case 13:
                unlockedString = "unlockedUni";
                lockedString = "lockedUni";
                puntuacioarest = 7500;
                break;
            case 14:
                unlockedString = "unlockedAnd";
                lockedString = "lockedAnd";
                puntuacioarest = 10000;
                break;
            default:
                unlockedString = "";
                lockedString = "";
                puntuacioarest = 9999;
                break;
        }
        unlocked = PlayerPrefs.GetInt(unlockedString) == 1;
        locked = PlayerPrefs.GetInt(lockedString) == 0;
        Jugar.SetActive(unlocked);
        Desbloquejar.SetActive(locked);

    }
    void Update()
    {
        puntuacioarest = (puntuacioarest + (250 * (Inmortal.inmortal.Increment * Inmortal.inmortal.Increment)));
    }

    public void Buy()
    {
        Inmortal.inmortal.puntuaciomoneMaxima -= puntuacioarest;
        Inmortal.inmortal.Increment = Inmortal.inmortal.Increment + 1;
        unlocked = true;
        PlayerPrefs.SetInt((unlockedString), 1);
        PlayerPrefs.SetInt((lockedString), 1);
        PlayerPrefs.Save();
        Jugar.SetActive(true);
        Desbloquejar.SetActive(false);
        SiMon.SetActive(false);
        Social.ReportProgress("CgkI19XKzYANEAIQCA", (100/13), (bool success) => { });
        Inmortal.inmortal.Guardar();
        ActualitzarMarcador();

    }
    void ActualitzarMarcador()
    {
        MonTot2.text = Inmortal.inmortal.puntuaciomoneMaxima.ToString();
        Marcador.text = puntuaciomon.ToString();
        Marcador2.text = puntuaciomon.ToString();
    }
}

