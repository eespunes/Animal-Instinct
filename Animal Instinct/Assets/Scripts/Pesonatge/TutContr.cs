using UnityEngine;
using System.Collections;

public class TutContr : MonoBehaviour
{
        public static Controlador Control;
        private float Força = 10000f;
        private float Força2 = -5f;
        private float Posicio = -5f;
        private float Posicio2 = 5f;
        public Rigidbody rb;

        public bool EstaTocantelTerra = true;
        public bool TocantSpine = false;
        public bool enelTerra = true;
        public bool Xocar = true;
        public bool Xocar2 = false;
        public bool SpineenelTerra = false;
        public Transform ComprovadorTerra;
        public Transform ComprovadorSpine;
        private float ratio = 0.02f;
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

        void Awake()
        {
            animator = GetComponent<Animator>();
        }

        void FixedUpdate()
        {
            enelTerra = Physics.OverlapSphere(ComprovadorTerra.position, ratio, Terra).Length > 0;
            Xocar = Physics.OverlapSphere(ComprovadorTerra.position, ratio, Xoc).Length > 0;
            Xocar2 = Physics.OverlapSphere(ComprovadorTerra.position, ratio, Xoc2).Length > 0;
            animator.SetBool("EstaTocantelTerra", enelTerra);
            SpineenelTerra = Physics.OverlapSphere(ComprovadorSpine.position, ratio, Terra).Length > 0;
            animator.SetBool("TocantSpine", TocantSpine);

        }

        void Estirar() { StartCoroutine(Begin()); }

        IEnumerator Begin()
        {
            TocantSpine = true;
            GetComponent<AudioSource>().clip = Estirat;
            GetComponent<AudioSource>().Play();
            yield return new WaitForSeconds(temps);
            TocantSpine = false;
        }
        void Saltar() { StartCoroutine(Begin2()); }
        IEnumerator Begin2()
        {
            rb.AddForce(0, Força, 0);
            GetComponent<AudioSource>().clip = Salt;
            GetComponent<AudioSource>().Play();
            yield return new WaitForSeconds(temps);
            rb.AddForce(0, Força2, 0);
            yield return new WaitForSeconds(0.1f);
            rb.position = new Vector3(rb.position.x, -78.82835f, rb.position.z);
        }
        void Esquerra()
        {
            if ((rb.position.x <= -74f))
            {
            }
            else
            {
                rb.transform.Translate(Posicio, 0, 0);
            }
        }
        void Dreta()
        {
            if (rb.position.x >= -70f)
            {
            }
            else
            {
                rb.transform.Translate(Posicio2, 0, 0);
            }

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

                    // Swipe up
                    if (enelTerra && (currentSwipe.y > 0 && currentSwipe.x > -0.5f && currentSwipe.x < 0.5f) && Time.timeScale != 0)
                    {
                        swipeDirection = Swipe.Up;
                        Saltar();
                        //Salts();
                        // Swipe down
                    }
                    else if ((currentSwipe.y < 0 && currentSwipe.x > -0.5f && currentSwipe.x < 0.5f) && Time.timeScale != 0)
                    {
                        swipeDirection = Swipe.Down;

                        Estirar();

                        // Swipe left
                    }
                    if (enelTerra && (currentSwipe.x < 0 && currentSwipe.y > -0.5f && currentSwipe.y < 0.5f) && Time.timeScale != 0)
                    {
                        swipeDirection = Swipe.Left;
                        Esquerra();

                        // Swipe right
                    }
                    else if (enelTerra && (currentSwipe.x > 0 && currentSwipe.y > -0.5f && currentSwipe.y < 0.5f) && Time.timeScale != 0)
                    {
                        swipeDirection = Swipe.Right;
                        Dreta();

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

                    //Swipe directional check
                    // Swipe up
                    if (enelTerra && (currentSwipe.y > 0 && currentSwipe.x > -0.5f && currentSwipe.x < 0.5f) && Time.timeScale != 0)
                    {
                        //Salts ();
                        Saltar();

                        // Swipe down
                    }
                    else if ((currentSwipe.y < 0 && currentSwipe.x > -0.5f && currentSwipe.x < 0.5f) && Time.timeScale != 0)
                    {
                        Estirar();
                        // Swipe left
                    }
                    if (enelTerra && (currentSwipe.x < 0 && currentSwipe.y > -0.5f && currentSwipe.y < 0.5f) && Time.timeScale != 0)
                    {
                        Esquerra();
                        // Swipe right
                    }
                    else if (enelTerra && (currentSwipe.x > 0 && currentSwipe.y > -0.5f && currentSwipe.y < 0.5f) && Time.timeScale != 0)
                    {
                        Dreta();

                    }
                }
            }
        }
    }



