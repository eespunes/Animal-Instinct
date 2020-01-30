using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class Comunicacio : MonoBehaviour {

	public string Escena;
    public bool ActivarIntersticial = false;
    public static int partidasiguiente = 1;
	private int partidaparaIntersticial = Random.Range(0,5);
         

    Canvas canvas;
    void Start ()
    {
        if (ActivarIntersticial == true)
        {
            if (partidasiguiente >= partidaparaIntersticial)
            {
                EasyGoogleMobileAds.GetInterstitialManager().ShowInterstitial();
                partidasiguiente = 1;
            }
            else
            {
                partidasiguiente++;
            }
        }
    }

	public void Menu(){
        SceneManager.LoadScene (Escena);
	}
   
}