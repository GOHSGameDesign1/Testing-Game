using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerClipping : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        transform.Translate(1, 0, 0);
    }
}
