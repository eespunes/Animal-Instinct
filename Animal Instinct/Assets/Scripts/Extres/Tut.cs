using UnityEngine;
using System.Collections;

public class Tut : MonoBehaviour {
    private bool unlocked;
    private bool locked;

    public GameObject Desbloquejar;
    public GameObject DesbloquejarC;
    public GameObject DesbloquejarA;
    public GameObject DesbloquejarF;
    public GameObject DesbloquejarAl;
    public GameObject DesbloquejarIt;
    public GameObject camera1;
    public GameObject camera2;

    Canvas canvas;

    void Start()
    {
        locked = PlayerPrefs.GetInt("Tut") == 0;
        Desbloquejar.SetActive(locked);
        DesbloquejarC.SetActive(locked);
        DesbloquejarA.SetActive(locked);
        DesbloquejarF.SetActive(locked);
        DesbloquejarAl.SetActive(locked);
        DesbloquejarIt.SetActive(locked);
    }

    public void Tuto()
    {
        PlayerPrefs.SetInt(("Tut"), 1);
        PlayerPrefs.Save();
        Desbloquejar.SetActive(false);
        DesbloquejarC.SetActive(false);
        DesbloquejarA.SetActive(false);
        DesbloquejarF.SetActive(false);
        DesbloquejarAl.SetActive(false);
        DesbloquejarIt.SetActive(false);
        camera1.SetActive(false);
        camera2.SetActive(true);
        Inmortal.inmortal.Guardar();
    }
}
