using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaddieStateManager : MonoBehaviour
{

    BaddieBaseState currentState;
    BaddieIntroState IntroState = new BaddieIntroState();
    BaddieInsultState InsultState = new BaddieInsultState();
    BaddieImpatientState ImpatientState = new BaddieImpatientState();

    // Start is called before the first frame update
    void Start()
    {
        //Sets IntroState to start on program start
        currentState = IntroState;

        // this means the context (This exact monobehavior)
        currentState.EnterState(this);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
