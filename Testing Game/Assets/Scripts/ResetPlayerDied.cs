using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetPlayerDied : MonoBehaviour
{

    public GlobalBool PlayerDiedDuringLevel;
    // Start is called before the first frame update
    void Awake()
    {
        PlayerDiedDuringLevel.value = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
