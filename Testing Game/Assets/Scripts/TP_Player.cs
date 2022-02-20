using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TP_Player : MonoBehaviour
{
    public float outerRightBound;
    public float outerLeftBound;

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x < outerLeftBound)
        {
            transform.Translate(new Vector3(outerRightBound - .5f, transform.position.y + 2, 0), Space.World);
        }

        if(transform.position.x > 22)
        {
            transform.Translate(new Vector2(-42.8f, transform.position.y + 2), Space.World);
        }
    }
}
