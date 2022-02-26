using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerGameBreak : MonoBehaviour
{
    public GameObject baddie;
    // Start is called before the first frame update
    void Start()
    {
        baddie = GameObject.Find("Baddie");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        baddie.GetComponent<BaddieStateManager>().StopAllCoroutines();
        baddie.GetComponent<BaddieStateManager>().SwitchToMadState();
    }
}
