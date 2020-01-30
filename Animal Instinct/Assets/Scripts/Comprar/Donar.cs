using UnityEngine;
using System.Collections;

public class Donar : MonoBehaviour {
    private bool unlocked;
    private bool locked;
    public TextMesh MonTot2;
    public GameObject Desbloquejar;
    public GameObject DesbloquejarC;
    public GameObject DesbloquejarA;
    public GameObject DesbloquejarF;
    public GameObject DesbloquejarAl;
    public GameObject DesbloquejarIt;
    Canvas canvas;

    void Start()
    {
        locked = PlayerPrefs.GetInt("5000") == 0;
        Desbloquejar.SetActive(locked);
        DesbloquejarC.SetActive(locked);
        DesbloquejarA.SetActive(locked);
        DesbloquejarF.SetActive(locked);
        DesbloquejarAl.SetActive(locked);
        DesbloquejarIt.SetActive(locked);
    }

    public void Buy()
    {
        PlayerPrefs.SetInt(("5000"), 1);
        PlayerPrefs.Save();
        Desbloquejar.SetActive(false);
        DesbloquejarC.SetActive(false);
        DesbloquejarA.SetActive(false);
        DesbloquejarF.SetActive(false);
        DesbloquejarAl.SetActive(false);
        DesbloquejarIt.SetActive(false);
        Inmortal.inmortal.puntuaciomoneMaxima += 1000000000;
        Inmortal.inmortal.Guardar();
        ActualitzarMarcador();

    }
    void ActualitzarMarcador()
    {
        MonTot2.text = Inmortal.inmortal.puntuaciomoneMaxima.ToString();
    }
}
