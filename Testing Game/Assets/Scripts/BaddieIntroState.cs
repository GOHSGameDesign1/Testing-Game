using UnityEngine;

public class BaddieIntroState : BaddieBaseState
{
    public override void EnterState(BaddieStateManager baddie)
    {
        Debug.Log("Hello from IntroState");
    }

    public override void UpdateState(BaddieStateManager baddie)
    {

    }
}
