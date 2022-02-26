using System.Collections;
using UnityEngine;

public class BaddieImpatientState : BaddieBaseState
{
    public string[] impatientLines = { "Please hurry up.", "You're wasting my time.", "Can you go any slower?", "Subject appears to be... more sluggish than usual" };
    public override void EnterState(BaddieStateManager baddie)
    {
        baddie.CoroutineStart(impatientLines[Random.Range(0,4)]);
    }

    public override void UpdateState(BaddieStateManager baddie)
    {

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
            yield return new WaitForSeconds(0.03f);
        }
    }
}
