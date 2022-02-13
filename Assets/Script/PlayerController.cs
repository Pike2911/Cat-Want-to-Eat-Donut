using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float Walkspeed = 70f;

    private Rigidbody2D rb2D;

    private float HorizontalMove = 0f;
    public static int PlayerLife = 2;


    private void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        
    }
    private void FixedUpdate()
    {
        HorizontalMove = Input.GetAxisRaw("Horizontal") * Walkspeed * Time.deltaTime;
        rb2D.MovePosition(new Vector2(transform.position.x + HorizontalMove, 0f));
    }
}
