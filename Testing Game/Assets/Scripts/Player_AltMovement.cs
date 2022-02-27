using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_AltMovement : MonoBehaviour
{
    public float speed;
    public Rigidbody2D rb;
    public Vector2 direction;
    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        direction = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        MovePlayer();

        animator.SetFloat("Velocity", direction.x);
        animator.SetFloat("VerticalVelocity", direction.y);
    }

    void MovePlayer()
    {
        rb.velocity = direction * speed;
    }




}
