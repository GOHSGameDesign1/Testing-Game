using System.Collections;
using UnityEngine;

public class BaddieImpatientState : BaddieBaseState
{
    public override void EnterState(BaddieStateManager baddie)
    {
        Debug.Log("Hurry Up!");
    }

    public override void UpdateState(BaddieStateManager baddie)
    {
        if (baddie.playerDied == true)
        {
            baddie.playerDied = false;
            baddie.SwitchState(baddie.InsultState);
        }
    }

    public override IEnumerator CoroutineState(BaddieStateManager baddie)
    {
        yield return new WaitForSeconds(5f);
        baddie.SwitchState(baddie.ImpatientState);

        //throw new System.NotImplementedException();
    }
}
