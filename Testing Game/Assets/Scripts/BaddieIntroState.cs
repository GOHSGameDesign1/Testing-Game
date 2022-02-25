using System.Collections;
using UnityEngine;

public class BaddieIntroState : BaddieBaseState
{
    public string[] introLines = { "This is level 1", "This is level 2", "This is level 3" };

    public override void EnterState(BaddieStateManager baddie)
    {
        if (baddie.playerDied == false)
        {
            Debug.Log(introLines[Random.Range(0, 3)]);
        }
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
        yield return new WaitForSeconds(5f);
        baddie.SwitchState(baddie.ImpatientState);

        //throw new System.NotImplementedException();
    }
}
