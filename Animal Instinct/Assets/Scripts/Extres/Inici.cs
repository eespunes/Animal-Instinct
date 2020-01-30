using UnityEngine;
using System.Collections;

public class Inici : MonoBehaviour {
    public GameObject A,B;
    public Canvas canvas;

    void Start()
    {

        Pause();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Resume();
        }
    }

    public void Pause()
    {
        Time.timeScale = Time.timeScale == 0 ? 1 : 0;
        A.SetActive(false);

    }
    public void Resume()
    {
        canvas.enabled = !canvas.enabled;
        Time.timeScale = Time.timeScale == 0 ? 1 : 0;
        A.SetActive(true);
    }
	public void activar(){
		B.SetActive (true);
	}
}
