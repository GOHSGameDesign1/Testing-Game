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

    public override IEnumerator TypeSentence(BaddieStateManager baddie, string sentence)
    {
        baddie.dialogueText.text = "";
        foreach (char letter in sentence.ToCharArray())
        {
            baddie.dialogueText.text += letter;
            baddie.talkingAudio.Play();
            yield return new WaitForSeconds(0.03f);
        }
    }
}
