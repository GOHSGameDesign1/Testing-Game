using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaddieStateManager : MonoBehaviour
{
    
    BaddieBaseState currentState;
    public BaddieIntroState IntroState = new BaddieIntroState();
    public BaddieInsultState InsultState = new BaddieInsultState();
    public BaddieImpatientState ImpatientState = new BaddieImpatientState();

    public bool isLeaving = false;
    public GlobalBool playerDiedDuringLevel;

    // Start is called before the first frame update
    void Start()
    {
        //Sets IntroState to start on program start
        if (playerDiedDuringLevel.value == true)
        {
            currentState = InsultState;
        }
        else 
        {
            currentState = IntroState; 
        }

        // this means the context (This exact monobehavior)
        currentState.EnterState(this);

        StartCoroutine(currentState.CoroutineState(this));

    }

    // Update is called once per frame
    void Update()
    {
        //player = GameObject.Find("Player");
        currentState.UpdateState(this);
    }

    public void SwitchState(BaddieBaseState state)
    {
        currentState = state;
        state.EnterState(this);
        StartCoroutine(currentState.CoroutineState(this));
    }
}
