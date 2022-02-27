using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerClipping : MonoBehaviour
{

    private bool colliding;
    // Start is called before the first frame update
    void Start()
    {
        colliding = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        colliding = true;
        Debug.Log("Triggered!");
        transform.Translate(0, 1.1f, 0);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        colliding = false;
    }
}
