using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.Audio;

public class PauseManager : MonoBehaviour {
    public Slider Musica;
    public Slider Efectes;
    public GameObject A;

    public AudioMixerSnapshot Pausa;
    public AudioMixerSnapshot Joc;



    public string Escena;
    Canvas canvas;
   public void LoadState()
    {
        Musica.value= PlayerPrefs.GetFloat("Musica", -20f);
        Efectes.value= PlayerPrefs.GetFloat("Efectes", -15f);
    }
   public void SaveState()
    {
        PlayerPrefs.SetFloat("Musica", Musica.value);
        PlayerPrefs.SetFloat("Efectes", Efectes.value);
    }

    void Start()
    {
        canvas = GetComponent<Canvas>();
        canvas.enabled = false;
        LoadState();
    }
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Pause();
        }
    }
    public void Quit()
    {
        Application.Quit();
    }

    public void Pause()
    {
        canvas.enabled = !canvas.enabled;
        Time.timeScale = Time.timeScale == 0 ? 1 : 0;
        A.SetActive(false);
        Pausa.TransitionTo(0.01f);
    }
    public void Resume()
    {
        canvas.enabled = !canvas.enabled;
        Time.timeScale = Time.timeScale == 0 ? 1 : 0;
        SaveState();
        A.SetActive(true);
        Joc.TransitionTo(0.01f);
    }

    public void Menu()
    {
        SaveState();
        SceneManager.LoadScene(Escena);       

    }
    public void Menupausa()
    {
        SaveState();
        Time.timeScale = Time.timeScale == 0 ? 1 : 0;
        SceneManager.LoadScene(Escena);
    }
}