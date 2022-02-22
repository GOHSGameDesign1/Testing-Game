using System.Collections;
using UnityEngine;

public class BaddieIntroState : BaddieBaseState
{
    public override void EnterState(BaddieStateManager baddie)
    {
        Debug.Log("Hello from IntroState");
    }

    public override void UpdateState(BaddieStateManager baddie)
    {
        if(baddie.playerDied == true)
        {
            baddie.playerDied = false;
            baddie.SwitchState(baddie.InsultState);
        }
    }

    public override IEnumerator CoroutineState(BaddieStateManager baddie)
    {
        yield return new WaitForSeconds(3f);
        baddie.SwitchState(baddie.ImpatientState);

        //throw new System.NotImplementedException();
    }
}
