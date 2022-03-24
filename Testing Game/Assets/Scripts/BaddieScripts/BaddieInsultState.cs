using System.Collections;
using UnityEngine;

public class BaddieInsultState : BaddieBaseState
{
    
    public override void EnterState(BaddieStateManager baddie)
    {
        int insultLine = Random.Range(0, baddie.insultLines.Length);

        baddie.StartTypeSentence(baddie.insultLines[insultLine].sentence);
        baddie.SwitchFace(baddie.insultLines[insultLine].Face);
    }

    public override void UpdateState(BaddieStateManager baddie)
    {

    }

    public override IEnumerator ImpatientTimer(BaddieStateManager baddie)
    {
        yield return new WaitForSeconds(7f);
        baddie.SwitchState(baddie.ImpatientState);

        //throw new System.NotImplementedException();
    }




}
