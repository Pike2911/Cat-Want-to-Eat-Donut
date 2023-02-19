using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private Transform Restart;
    [SerializeField] private Transform PlayAgain;
    [SerializeField] private GameController gameCon;

    public static int PlayerLife = 2;

    //[SerializeField] private float Walkspeed = 70f;

    private Rigidbody2D rb2D;
    private Animator animator;

    private Touch theTouch;

    //private float HorizontalMove = 0f;

    public void Score()
    {
        ScoreCounter.ScoreValue += 1;
        animator.SetTrigger("EatDonut");
    }
    private void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }
    private void Update()
    {
        if(Time.timeScale == 1)
        {
            if (Input.touchCount > 0)
            {
                theTouch = Input.GetTouch(0);
                if (theTouch.phase == TouchPhase.Moved)
                {
                    Vector3 worldPoint = Camera.main.ScreenToWorldPoint(theTouch.position);
                    if (worldPoint.x < -3f)
                    {
                        transform.position = (new Vector2(-2.9f, transform.position.y));
                    }
                    else if (worldPoint.x > 3f)
                    {
                        transform.position = (new Vector2(2.9f, transform.position.y));
                    }
                    else
                    {
                        transform.position = (new Vector2(worldPoint.x, transform.position.y));
                    }
                }
            }
        }
        
    }
    //private void FixedUpdate()
    //{
    //    HorizontalMove = Input.GetAxisRaw("Horizontal") * Walkspeed * Time.deltaTime;
    //    rb2D.MovePosition(new Vector2(theTouch.position.x, 0f));
    //}
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Fail")
        {
            Destroy(collision.gameObject);
            gameCon.PauseGame();
            if (PlayerController.PlayerLife > 0)
            {
                Restart.gameObject.SetActive(true);
            }
            else if (PlayerController.PlayerLife == 0)
            {
                PlayAgain.gameObject.SetActive(true);
            }
        }

        if (collision.gameObject.tag == "Score")
        {
            Score();
        }
    }
}
