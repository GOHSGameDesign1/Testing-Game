using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TP_Player : MonoBehaviour
{
    public Vector3 ScreenBounds;

    private void Start()
    {
        ScreenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
    }
    // Update is called once per frame
    void Update()
    {
        if(transform.position.x < ScreenBounds.x - 1)
        {
            Debug.Log("Too Far!");
        }
    }
}
