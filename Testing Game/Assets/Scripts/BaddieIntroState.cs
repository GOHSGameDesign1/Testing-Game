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
            //Debug.Log("INTRO STATE");

            //baddie.dialogueText.text = introLines[0];

            baddie.CoroutineStart(introLines[Random.Range(0,3)]);
        }

    }

    public override void UpdateState(BaddieStateManager baddie)
    {
        /*if(baddie.playerDiedDuringLevel.value == true)
        {
            baddie.SwitchState(baddie.InsultState);
        }*/
    }

    public override IEnumerator CoroutineState(BaddieStateManager baddie)
    {
        yield return new WaitForSeconds(7f);
        baddie.SwitchState(baddie.ImpatientState);

        //throw new System.NotImplementedException();
    }

    public override IEnumerator TypeSentence(BaddieStateManager baddie, string sentence)
    {
        baddie.dialogueText.text = "";
        foreach (char letter in sentence.ToCharArray())
        {
            baddie.dialogueText.text += letter;
            yield return new WaitForSeconds(0.003f);
        }
    }
}
