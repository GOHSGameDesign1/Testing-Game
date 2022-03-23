using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BaddieImpatientState : BaddieBaseState
{
    public override void EnterState(BaddieStateManager baddie)
    {
        if (SceneManager.GetActiveScene().buildIndex < 6)
        {
            baddie.StartTypeSentence(baddie.impatientLines.sentences[Random.Range(0, 6)]);
            baddie.SwitchFace(baddie.AnnoyedFace);
        }
    }

    public override void UpdateState(BaddieStateManager baddie)
    {

    }

    public override IEnumerator ImpatientTimer(BaddieStateManager baddie)
    {
            yield return new WaitForSeconds(7f);
            baddie.SwitchState(baddie.ImpatientState);

        //throw new System.NotImplementedException();
    }


}
