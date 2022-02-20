using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed;
    public Rigidbody2D rb;
    public Vector2 direction;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        direction = new Vector2(Input.GetAxis("Horizontal"), 0);
        MovePlayer();
        Debug.Log(Input.GetAxis("Horizontal"));
    }

    void MovePlayer()
    {
         rb.MovePosition((Vector2)transform.position + direction * speed * Time.deltaTime);
        //transform.Translate(new Vector2(Time.deltaTime, 0));
    }
}
