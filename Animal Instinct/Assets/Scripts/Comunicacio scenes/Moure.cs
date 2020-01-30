using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Moure : MonoBehaviour {

	public GameObject cameraactual;
	public GameObject cameraesquerra;
	public GameObject cameradreta;
	public GameObject camera1;
	public GameObject camera2;
	public float minSwipeLength = 5f;
	Vector2 firstPressPos;
	Vector2 secondPressPos;
	Vector2 currentSwipe;
	Vector2 firstClickPos;
	Vector2 secondClickPos;
	public static Swipe swipeDirection;
    Canvas canvas;
    public Slider Musica;
    public Slider Efectes;
    public void LoadState()
    {
        Musica.value = PlayerPrefs.GetFloat("Musica", -20f);
        Efectes.value = PlayerPrefs.GetFloat("Efectes", -15f);
    }
    public void SaveState()
    {
        PlayerPrefs.SetFloat("Musica", Musica.value);
        PlayerPrefs.SetFloat("Efectes", Efectes.value);
    }

    void Start()
    {
        LoadState();
    }
    void Update()
    {
        if (Input.touches.Length > 0)
        {
            Touch t = Input.GetTouch(0);

            if (t.phase == TouchPhase.Began)
            {
                firstPressPos = new Vector2(t.position.x, t.position.y);
            }

            if (t.phase == TouchPhase.Ended)
            {
                secondPressPos = new Vector2(t.position.x, t.position.y);
                currentSwipe = new Vector3(secondPressPos.x - firstPressPos.x, secondPressPos.y - firstPressPos.y);

                // Make sure it was a legit swipe, not a tap
                if (currentSwipe.magnitude < minSwipeLength)
                {
                    swipeDirection = Swipe.None;
                    return;
                }

                currentSwipe.Normalize();

                if ((currentSwipe.x < 0 && currentSwipe.y > -0.5f && currentSwipe.y < 0.5f))
                {
                    swipeDirection = Swipe.Left;
                    cameraactual.SetActive(false);
                    cameradreta.SetActive(true);

                    // Swipe right
                }
                else if ((currentSwipe.x > 0 && currentSwipe.y > -0.5f && currentSwipe.y < 0.5f))
                {
                    swipeDirection = Swipe.Right;
                    cameraactual.SetActive(false);
                    cameraesquerra.SetActive(true);

                }
            }
        }
        else
        {

            if (Input.GetMouseButtonDown(0))
            {
                firstClickPos = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
            }
            else
            {
                swipeDirection = Swipe.None;
                //Debug.Log ("None");
            }
            if (Input.GetMouseButtonUp(0))
            {
                secondClickPos = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
                currentSwipe = new Vector3(secondClickPos.x - firstClickPos.x, secondClickPos.y - firstClickPos.y);

                // Make sure it was a legit swipe, not a tap
                if (currentSwipe.magnitude < minSwipeLength)
                {
                    swipeDirection = Swipe.None;
                    return;
                }

                currentSwipe.Normalize();

                if ((currentSwipe.x < 0 && currentSwipe.y > -0.5f && currentSwipe.y < 0.5f))
                {
                    cameraactual.SetActive(false);
                    cameradreta.SetActive(true);
                    // Swipe right
                }
                else if ((currentSwipe.x > 0 && currentSwipe.y > -0.5f && currentSwipe.y < 0.5f))
                {
                    cameraactual.SetActive(false);
                    cameraesquerra.SetActive(true);
                }
            }
        }
        
	}
		public void OnMouseDown(){
        
        camera1.SetActive (false);
		camera2.SetActive (true);
        SaveState();
		}
}
