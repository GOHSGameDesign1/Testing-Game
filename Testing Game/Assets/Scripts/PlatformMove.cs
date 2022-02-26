using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMove : MonoBehaviour
{
    public Rigidbody2D rb;
    public float value;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("je pense que tu pense que nous pensons que vous pensez que");
    }

    // Update is called once per frame
    void Update()
    {
        //rb.MovePosition(new Vector2(transform.position.x + 2, transform.position.y));
        //rb.AddForce(Vector2.right * 24440);
        rb.velocity = Vector2.right * 2 * value;
    }
}
