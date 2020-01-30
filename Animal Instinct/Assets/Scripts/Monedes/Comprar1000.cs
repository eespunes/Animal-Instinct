
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.Audio;

public class Comprar1000 : MonoBehaviour {
    private int puntuacioarest = 6000;
    public GameObject NoMon;
    public GameObject SiMon;
    public Text Marcador2;
    public string Comprar;
    public string Complet;
    public TextMesh Monedes;
    
    void Start()
    {
		puntuacioarest = (puntuacioarest + (250 * (Inmortal.inmortal.Increment * Inmortal.inmortal.Increment)));
    }
    void Update()
    {
        Complet = (Comprar + System.Environment.NewLine + puntuacioarest);
        Marcador2.text = Complet.ToString();
        Monedes.text = (puntuacioarest).ToString();
    }
    public void Buy()
    {
        if (Inmortal.inmortal.puntuaciomoneMaxima < puntuacioarest)
        {
            NoMone();
        }
        else if (Inmortal.inmortal.puntuaciomoneMaxima >= puntuacioarest)
        {
            SiMon.SetActive(true);

        }
    }
    void NoMone() { StartCoroutine(Begin()); }

    IEnumerator Begin()
    {
        NoMon.SetActive(true);
        yield return new WaitForSeconds(1.5f);
        NoMon.SetActive(false);
    }
}

