using System.Collections;
using UnityEngine;

public class BaddieIntroState : BaddieBaseState
{
    public string[] introLines = { "This is level 1", "This is level 2", "This is level 3" };

    public override void EnterState(BaddieStateManager baddie)
    {
        if (baddie.playerDiedDuringLevel.value == true)
        {
            baddie.SwitchState(baddie.InsultState);
        }
        else
        {
            //Debug.Log(introLines[Random.Range(0, 3)]);
            Debug.Log("INTRO STATE");
        }

    }

    public override void UpdateState(BaddieStateManager baddie)
    {
        if(baddie.playerDiedDuringLevel.value == true)
        {
            baddie.SwitchState(baddie.InsultState);
        }
    }

    public override IEnumerator CoroutineState(BaddieStateManager baddie)
    {
        yield return new WaitForSeconds(5f);
        //baddie.SwitchState(baddie.ImpatientState);

        //throw new System.NotImplementedException();
    }
}
