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
        //rb.MovePosition(new Vector2(transform.position.x + 0.1f * value, transform.position.y));
        //rb.AddForce(Vector2.right * 24440 * value);
        rb.velocity = Vector2.right * 2 * value;
        //rb.position = rb.position - new Vector2(-0.3f, 0) * value;
    }
}
