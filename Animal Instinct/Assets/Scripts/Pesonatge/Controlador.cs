using UnityEngine;
using System.Collections;

public enum Swipe { None, Up, Down, Left, Right };

public class Controlador : MonoBehaviour {
    public static Controlador Control;
    private float Força = 10000f;
	private float Força2 = -5f;
	private float Posicio = -5f;
	private float Posicio2 = 5f; 
	public Rigidbody rb;
	private float velocitat = 30f;
    public bool Saltant = false;
	
	public bool EstaTocantelTerra = true;
	public bool TocantSpine = false;
	public bool enelTerra = true;
    public bool Xocar = true;
    public bool Xocar2 = false;
    public bool SpineenelTerra = false;
    public Transform ComprovadorTerra;
	public Transform ComprovadorSpine;
	private float ratio =0.02f;
    public LayerMask Terra;
    public LayerMask Xoc;
    public LayerMask Xoc2;
    private float temps = 0.4f;
	private Animator animator;
	
	public float minSwipeLength = 5f;
	Vector2 firstPressPos;
	Vector2 secondPressPos;
	Vector2 currentSwipe;
	public static Swipe swipeDirection;
	Vector2 firstClickPos;
	Vector2 secondClickPos;
	
    public AudioClip Salt;
	public AudioClip Estirat;	
		
	void Awake() {
		animator = GetComponent<Animator>();		
	}

	void FixedUpdate () {
		rb.velocity = new Vector3 (rb.velocity.x, rb.velocity.y, velocitat);
        animator.SetFloat ("Velocitat", rb.velocity.z);
		enelTerra = Physics.OverlapSphere (ComprovadorTerra.position, ratio, Terra).Length > 0;
        Xocar = Physics.OverlapSphere(ComprovadorTerra.position, ratio, Xoc).Length > 0;
        Xocar2 = Physics.OverlapSphere(ComprovadorTerra.position, ratio, Xoc2).Length > 0;
        animator.SetBool ("EstaTocantelTerra", enelTerra);
        SpineenelTerra = Physics.OverlapSphere (ComprovadorSpine.position, ratio, Terra).Length > 0;
		animator.SetBool ("TocantSpine", TocantSpine);
        Correr();
        Mort();
	}


    void Estirar () { StartCoroutine (Begin ()); }
	
	IEnumerator Begin ()
	{
		TocantSpine = true;
		GetComponent<AudioSource>().clip = Estirat;
		GetComponent<AudioSource>().Play();
		yield return new WaitForSeconds (temps);
		TocantSpine = false;
	}
	void Saltar () { StartCoroutine (Begin2 ()); }
		IEnumerator Begin2 ()
		{
		Saltant = true;
        rb.AddForce (0,Força,0);
		GetComponent<AudioSource>().clip = Salt;
		GetComponent<AudioSource>().Play();
		yield return new WaitForSeconds (temps);
		rb.AddForce (0, Força2, 0);
        yield return new WaitForSeconds(0.1f);
        rb.position = new Vector3(rb.position.x, 1.941707f, rb.position.z);
        Saltant = false;
    }
   void Correr() { StartCoroutine(Begin3()); }

    IEnumerator Begin3()
    {
        if (Saltant == true) { }
        else if ((Saltant == false) || (rb.position != new Vector3(rb.position.x, 1.941707f, rb.position.z)))
            {
                rb.position = new Vector3(rb.position.x, 1.941707f, rb.position.z);
            }

        if (velocitat < 40)
        {
            yield return new WaitForSeconds(1f);
            velocitat = 30.1f;
            yield return new WaitForSeconds(1f);
            velocitat = 30.2f;
            yield return new WaitForSeconds(1f);
            velocitat = 30.3f;
            yield return new WaitForSeconds(1f);
            velocitat = 30.4f;
            yield return new WaitForSeconds(1f);
            velocitat = 30.5f;
            yield return new WaitForSeconds(1f);
            velocitat = 30.6f;
            yield return new WaitForSeconds(1f);
            velocitat = 30.7f;
            yield return new WaitForSeconds(1f);
            velocitat = 30.8f;
            yield return new WaitForSeconds(1f);
            velocitat = 30.9f;
            yield return new WaitForSeconds(1f);
            velocitat = 31f;
            yield return new WaitForSeconds(1f);
            velocitat = 31.1f;
            yield return new WaitForSeconds(1f);
            velocitat = 31.2f;
            yield return new WaitForSeconds(1f);
            velocitat = 31.3f;
            yield return new WaitForSeconds(1f);
            velocitat = 31.4f;
            yield return new WaitForSeconds(1f);
            velocitat = 31.5f;
            yield return new WaitForSeconds(1f);
            velocitat = 31.6f;
            yield return new WaitForSeconds(1f);
            velocitat = 31.7f;
            yield return new WaitForSeconds(1f);
            velocitat = 31.8f;
            yield return new WaitForSeconds(1f);
            velocitat = 31.9f;
            yield return new WaitForSeconds(1f);
            velocitat = 32f;
            yield return new WaitForSeconds(1f);
            velocitat = 32.1f;
            yield return new WaitForSeconds(1f);
            velocitat = 32.2f;
            yield return new WaitForSeconds(1f);
            velocitat = 32.3f;
            yield return new WaitForSeconds(1f);
            velocitat = 32.4f;
            yield return new WaitForSeconds(1f);
            velocitat = 32.5f;
            yield return new WaitForSeconds(1f);
            velocitat = 32.6f;
            yield return new WaitForSeconds(1f);
            velocitat = 32.7f;
            yield return new WaitForSeconds(1f);
            velocitat = 32.8f;
            yield return new WaitForSeconds(1f);
            velocitat = 32.9f;
            yield return new WaitForSeconds(1f);
            velocitat = 33f;
            yield return new WaitForSeconds(1f);
            velocitat = 33.1f;
            yield return new WaitForSeconds(1f);
            velocitat = 33.2f;
            yield return new WaitForSeconds(1f);
            velocitat = 33.3f;
            yield return new WaitForSeconds(1f);
            velocitat = 33.4f;
            yield return new WaitForSeconds(1f);
            velocitat = 33.5f;
            yield return new WaitForSeconds(1f);
            velocitat = 33.6f;
            yield return new WaitForSeconds(1f);
            velocitat = 33.7f;
            yield return new WaitForSeconds(1f);
            velocitat = 33.8f;
            yield return new WaitForSeconds(1f);
            velocitat = 33.9f;
            yield return new WaitForSeconds(1f);
            velocitat = 34f;
            yield return new WaitForSeconds(1f);
            velocitat = 34.1f;
            yield return new WaitForSeconds(1f);
            velocitat = 34.2f;
            yield return new WaitForSeconds(1f);
            velocitat = 34.3f;
            yield return new WaitForSeconds(1f);
            velocitat = 34.4f;
            yield return new WaitForSeconds(1f);
            velocitat = 34.5f;
            yield return new WaitForSeconds(1f);
            velocitat = 34.6f;
            yield return new WaitForSeconds(1f);
            velocitat = 34.7f;
            yield return new WaitForSeconds(1f);
            velocitat = 34.8f;
            yield return new WaitForSeconds(1f);
            velocitat = 34.9f;
            yield return new WaitForSeconds(1f);
            velocitat = 35f;
            yield return new WaitForSeconds(1f);
            velocitat = 35.1f;
            yield return new WaitForSeconds(1f);
            velocitat = 35.2f;
            yield return new WaitForSeconds(1f);
            velocitat = 35.3f;
            yield return new WaitForSeconds(1f);
            velocitat = 35.4f;
            yield return new WaitForSeconds(1f);
            velocitat = 35.5f;
            yield return new WaitForSeconds(1f);
            velocitat = 35.6f;
            yield return new WaitForSeconds(1f);
            velocitat = 35.7f;
            yield return new WaitForSeconds(1f);
            velocitat = 35.8f;
            yield return new WaitForSeconds(1f);
            velocitat = 35.9f;
            yield return new WaitForSeconds(1f);
            velocitat = 36f;
            yield return new WaitForSeconds(1f);
            velocitat = 36.1f;
            yield return new WaitForSeconds(1f);
            velocitat = 36.2f;
            yield return new WaitForSeconds(1f);
            velocitat = 36.3f;
            yield return new WaitForSeconds(1f);
            velocitat = 36.4f;
            yield return new WaitForSeconds(1f);
            velocitat = 36.5f;
            yield return new WaitForSeconds(1f);
            velocitat = 36.6f;
            yield return new WaitForSeconds(1f);
            velocitat = 36.7f;
            yield return new WaitForSeconds(1f);
            velocitat = 36.8f;
            yield return new WaitForSeconds(1f);
            velocitat = 36.9f;
            yield return new WaitForSeconds(1f);
            velocitat = 37f;
            yield return new WaitForSeconds(1f);
            velocitat = 37.1f;
            yield return new WaitForSeconds(1f);
            velocitat = 37.2f;
            yield return new WaitForSeconds(1f);
            velocitat = 37.3f;
            yield return new WaitForSeconds(1f);
            velocitat = 37.4f;
            yield return new WaitForSeconds(1f);
            velocitat = 37.5f;
            yield return new WaitForSeconds(1f);
            velocitat = 37.6f;
            yield return new WaitForSeconds(1f);
            velocitat = 37.7f;
            yield return new WaitForSeconds(1f);
            velocitat = 37.8f;
            yield return new WaitForSeconds(1f);
            velocitat = 37.9f;
            yield return new WaitForSeconds(1f);
            velocitat = 38f;
            yield return new WaitForSeconds(1f);
            velocitat = 38.1f;
            yield return new WaitForSeconds(1f);
            velocitat = 38.2f;
            yield return new WaitForSeconds(1f);
            velocitat = 38.3f;
            yield return new WaitForSeconds(1f);
            velocitat = 38.4f;
            yield return new WaitForSeconds(1f);
            velocitat = 38.5f;
            yield return new WaitForSeconds(1f);
            velocitat = 38.6f;
            yield return new WaitForSeconds(1f);
            velocitat = 38.7f;
            yield return new WaitForSeconds(1f);
            velocitat = 38.8f;
            yield return new WaitForSeconds(1f);
            velocitat = 38.9f;
            yield return new WaitForSeconds(1f);
            velocitat = 39f;
            yield return new WaitForSeconds(1f);
            velocitat = 39.1f;
            yield return new WaitForSeconds(1f);
            velocitat = 39.2f;
            yield return new WaitForSeconds(1f);
            velocitat = 39.3f;
            yield return new WaitForSeconds(1f);
            velocitat = 39.4f;
            yield return new WaitForSeconds(1f);
            velocitat = 39.5f;
            yield return new WaitForSeconds(1f);
            velocitat = 39.6f;
            yield return new WaitForSeconds(1f);
            velocitat = 39.7f;
            yield return new WaitForSeconds(1f);
            velocitat = 39.8f;
            yield return new WaitForSeconds(1f);
            velocitat = 39.9f;
            yield return new WaitForSeconds(1f);
            velocitat = 40f;
        }
        else
        {
            velocitat = 40f;
        }
    }
    void Esquerra (){
		if ((rb.position.x <= -74f)) {
		} else {
			rb.transform.Translate (Posicio, 0, 0);
		}
	}
	void Dreta (){
		if (rb.position.x >=-70f){
			}
			else{
			rb.transform.Translate (Posicio2,0,0);
			}

	}
    void Mort()
    {
        if (Xocar == true)
        {
            NotificationCenter.DefaultCenter().PostNotification(this, "Personatgehamort");
            GameObject persontge = GameObject.Find("Gat");
            persontge.SetActive(false);
        }
        if (Xocar2 == true)
        {
            NotificationCenter.DefaultCenter().PostNotification(this, "Personatgehamort");
            GameObject persontge = GameObject.Find("Gat");
            persontge.SetActive(false);
        }
    }


	void Update () {

        if (Input.touches.Length > 0) {
			Touch t = Input.GetTouch(0);
			
			if (t.phase == TouchPhase.Began) {
				firstPressPos = new Vector2(t.position.x, t.position.y);
			}
			
			if (t.phase == TouchPhase.Ended) {
				secondPressPos = new Vector2(t.position.x, t.position.y);
				currentSwipe = new Vector3(secondPressPos.x - firstPressPos.x, secondPressPos.y - firstPressPos.y);
				
				// Make sure it was a legit swipe, not a tap
				if (currentSwipe.magnitude < minSwipeLength) {
					swipeDirection = Swipe.None;
					return;
				}
				
				currentSwipe.Normalize();
				
				// Swipe up
				if (enelTerra && (currentSwipe.y > 0  && currentSwipe.x > -0.5f && currentSwipe.x < 0.5f) && Time.timeScale != 0) {
					swipeDirection = Swipe.Up;
					Saltar();
					//Salts();
					// Swipe down
				} else if ((currentSwipe.y < 0 && currentSwipe.x > -0.5f && currentSwipe.x < 0.5f)&& Time.timeScale !=0) {
					swipeDirection = Swipe.Down;

					Estirar();

					// Swipe left
				} if (enelTerra && (currentSwipe.x < 0 && currentSwipe.y > -0.5f && currentSwipe.y < 0.5f) && Time.timeScale != 0) {
					swipeDirection = Swipe.Left;
					Esquerra();

					// Swipe right
				} else if (enelTerra && (currentSwipe.x > 0 && currentSwipe.y > -0.5f && currentSwipe.y < 0.5f) && Time.timeScale != 0) {
					swipeDirection = Swipe.Right;
					Dreta();

				}
			}
		} else {
			
			if (Input.GetMouseButtonDown(0)) {
				firstClickPos = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
			} else {
				swipeDirection = Swipe.None;
				//Debug.Log ("None");
			}
			if (Input.GetMouseButtonUp (0)){
				secondClickPos = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
				currentSwipe = new Vector3(secondClickPos.x - firstClickPos.x, secondClickPos.y - firstClickPos.y);
				
				// Make sure it was a legit swipe, not a tap
				if (currentSwipe.magnitude < minSwipeLength) {
					swipeDirection = Swipe.None;
					return;
				}
				
				currentSwipe.Normalize();
				
				//Swipe directional check
				// Swipe up
				if (enelTerra && (currentSwipe.y > 0  && currentSwipe.x > -0.5f && currentSwipe.x < 0.5f) && Time.timeScale != 0) {
					//Salts ();
					Saltar();

					// Swipe down
				} else if ((currentSwipe.y < 0 && currentSwipe.x > -0.5f && currentSwipe.x < 0.5f) && Time.timeScale != 0)
                {
					Estirar();
					// Swipe left
				}if (enelTerra && (currentSwipe.x < 0 && currentSwipe.y > -0.5f && currentSwipe.y < 0.5f) && Time.timeScale != 0) {
					Esquerra();
					// Swipe right
				} else if (enelTerra && (currentSwipe.x > 0 && currentSwipe.y > -0.5f && currentSwipe.y < 0.5f) && Time.timeScale != 0) {
					Dreta();

				}
			}
		}
	}
}

