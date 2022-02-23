using System.Collections;
using UnityEngine;

public class BaddieInsultState : BaddieBaseState
{

    public string[] insults = { "Terrible", "Are you ok?", "Defective" };

    public override void EnterState(BaddieStateManager baddie)
    {
        Debug.Log(insults[Random.Range(0,3)]);
    }

    public override void UpdateState(BaddieStateManager baddie)
    {

    }

    public override IEnumerator CoroutineState(BaddieStateManager baddie)
    {
        yield return new WaitForSeconds(3f);
        baddie.SwitchState(baddie.ImpatientState);

        //throw new System.NotImplementedException();
    }

}
