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
    public GameObject player;

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
        currentState.UpdateState(this);
    }

    public void SwitchState(BaddieBaseState state)
    {
        currentState = state;
        state.EnterState(this);
    }
}
