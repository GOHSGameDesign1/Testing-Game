using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaddieMadState : BaddieBaseState
{
    public override void EnterState(BaddieStateManager baddie)
    {
        baddie.StartTypeSentence(baddie.madString);
        baddie.SwitchFace(baddie.madFace);
    }

    public override void UpdateState(BaddieStateManager baddie)
    {
        
    }

    public override IEnumerator CoroutineState(BaddieStateManager baddie)
    {
        yield return new WaitForSeconds(10f);
        baddie.SwitchState(baddie.ImpatientState);
    }


}
