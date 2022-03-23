using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BaddieImpatientState : BaddieBaseState
{
    public override void EnterState(BaddieStateManager baddie)
    {
        if (SceneManager.GetActiveScene().buildIndex < 6)
        {
            int impatientLine = Random.Range(0, baddie.impatientLines.Length);

            baddie.StartTypeSentence(baddie.impatientLines[impatientLine].sentence);
            baddie.SwitchFace(baddie.impatientLines[impatientLine].Face);
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
