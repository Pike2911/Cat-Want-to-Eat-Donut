using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float Walkspeed = 4f;

    private Rigidbody2D rb2D;

    float HorizontalMove = 0f;


    private void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        HorizontalMove = Input.GetAxisRaw("Horizontal") * Walkspeed * Time.deltaTime;
    }
    private void FixedUpdate()
    {
        rb2D.MovePosition(new Vector2(transform.position.x + HorizontalMove, 0f));
    }
}
