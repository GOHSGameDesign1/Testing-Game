using System.Collections;
using UnityEngine;

public class BaddieImpatientState : BaddieBaseState
{
    public override void EnterState(BaddieStateManager baddie)
    {
        //Debug.Log("Hurry Up!");
        //baddie.dialogueText.text = "Hurry Up!";
        baddie.CoroutineStart("Hurry Up!");
    }

    public override void UpdateState(BaddieStateManager baddie)
    {
        /*if (baddie.playerDiedDuringLevel.value == true)
        {
            baddie.SwitchState(baddie.InsultState);
        }*/
    }

    public override IEnumerator CoroutineState(BaddieStateManager baddie)
    {
        yield return new WaitForSeconds(5f);
        baddie.SwitchState(baddie.ImpatientState);

        //throw new System.NotImplementedException();
    }

    public override IEnumerator TypeSentence(BaddieStateManager baddie, string sentence)
    {
        baddie.dialogueText.text = "";
        foreach (char letter in sentence.ToCharArray())
        {
            baddie.dialogueText.text += letter;
            yield return new WaitForSeconds(0.03f);
        }
    }
}
