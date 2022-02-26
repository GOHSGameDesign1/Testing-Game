using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed;
    public Rigidbody2D rb;
    public float direction;
    public float JumpForce;
    private bool isJumping = false;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        direction = (Input.GetAxisRaw("Horizontal"));
        MovePlayer();

        if (Input.GetKeyDown(KeyCode.UpArrow) && isJumping == false)
        {
            isJumping = true;
            Jump();
        }
    }

    void MovePlayer()
    {
        rb.velocity = new Vector2(direction * speed, rb.velocity.y);
    }

    void Jump()
    {
        rb.velocity = Vector2.up * JumpForce;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Platform")
        {
            isJumping = false;
        }
    }
}
