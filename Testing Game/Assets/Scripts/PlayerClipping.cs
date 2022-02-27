using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerClipping : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Triggered!");
        transform.Translate(0, 1.1f, 0);
    }
}
