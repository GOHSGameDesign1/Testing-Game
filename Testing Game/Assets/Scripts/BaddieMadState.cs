using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaddieMadState : BaddieBaseState
{
    public override void EnterState(BaddieStateManager baddie)
    {
        baddie.StartTypeSentence("What...");
    }

    public override void UpdateState(BaddieStateManager baddie)
    {
        
    }

    public override IEnumerator CoroutineState(BaddieStateManager baddie)
    {
        return null;
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
