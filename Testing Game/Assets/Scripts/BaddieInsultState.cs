using UnityEngine;

public class BaddieInsultState : BaddieBaseState
{
    public override void EnterState(BaddieStateManager baddie)
    {
        Debug.Log("You Suck! - From the Insult State");
    }

    public override void UpdateState(BaddieStateManager baddie)
    {

    }
}
