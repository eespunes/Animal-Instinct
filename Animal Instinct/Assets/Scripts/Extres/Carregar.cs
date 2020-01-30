using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class Carregar : MonoBehaviour {

    public float temps = 0.1f;
    public string Escena;

    void Start()
    {
        Cargar();
    }

    void Cargar() { StartCoroutine(Load()); }

    IEnumerator Load()
    {
      
        yield return new WaitForSeconds(temps);
        SceneManager.LoadScene(Escena);
#if UNITY_IPHONE
            Handheld.SetActivityIndicatorStyle(iOS.ActivityIndicatorStyle.Gray);
#elif UNITY_ANDROID
        Handheld.SetActivityIndicatorStyle(AndroidActivityIndicatorStyle.Small);
#endif

        Handheld.StartActivityIndicator();
    }
}
