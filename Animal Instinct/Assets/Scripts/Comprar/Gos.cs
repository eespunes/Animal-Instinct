using UnityEngine;
using System.Collections;

public class Gos : MonoBehaviour {
    private bool unlocked;
    private bool locked;
    private int puntuacioarest = 1000;
    public int puntuaciomon = 0;
    public TextMesh MonTot2;
    public GameObject Jugar;
    public GameObject Desbloquejar;
    public GameObject SiMon;
    public TextMesh Marcador;
    public TextMesh Marcador2;

    void Start()
    {
        unlocked = PlayerPrefs.GetInt("unlockedGo") == 1;
        locked = PlayerPrefs.GetInt("lockedGo") == 0;
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
        PlayerPrefs.SetInt(("unlockedGo"), 1);
        PlayerPrefs.SetInt(("lockedGo"), 1);
        PlayerPrefs.Save();
        Jugar.SetActive(true);
        Desbloquejar.SetActive(false);
        SiMon.SetActive(false);
        Social.ReportProgress("CgkI19XKzYANEAIQCA", (100 / 13), (bool success) => { });
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

