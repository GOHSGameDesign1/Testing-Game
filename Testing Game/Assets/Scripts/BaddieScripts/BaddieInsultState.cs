using System.Collections;
using UnityEngine;

public class BaddieInsultState : BaddieBaseState
{

    public override void EnterState(BaddieStateManager baddie)
    {
        //Debug.Log(insults[Random.Range(0,3)]);
        //Debug.Log("INSULT STATE");

        //baddie.dialogueText.text = insults[Random.Range(0,3)];
        baddie.StartTypeSentence(baddie.insultLines.sentences[Random.Range(0, 7)]);
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




}
