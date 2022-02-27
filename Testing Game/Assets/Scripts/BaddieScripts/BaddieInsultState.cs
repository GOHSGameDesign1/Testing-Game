using System.Collections;
using UnityEngine;

public class BaddieInsultState : BaddieBaseState
{

    public string[] insults = { "Terrible", "Are you ok?", "Defective", "Maybe I should've doubted you more..", "HOLY ur bad kid" };

    public override void EnterState(BaddieStateManager baddie)
    {
        //Debug.Log(insults[Random.Range(0,3)]);
        //Debug.Log("INSULT STATE");

        //baddie.dialogueText.text = insults[Random.Range(0,3)];
        baddie.StartTypeSentence(insults[Random.Range(0, 5)]);
        baddie.SwitchFace(baddie.LaughingFace);
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
