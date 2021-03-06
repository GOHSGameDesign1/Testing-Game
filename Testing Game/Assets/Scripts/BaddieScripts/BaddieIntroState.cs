using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BaddieIntroState : BaddieBaseState
{

    private int currentBuildIndex;

    public override void EnterState(BaddieStateManager baddie)
    {
        currentBuildIndex = SceneManager.GetActiveScene().buildIndex;

            switch (currentBuildIndex)
            {
                case 2:
                    baddie.StartTypeSentence(baddie.introLines.sentences[0]);
                    baddie.SwitchFace(baddie.NeutralFace);
                    break;
                case 3:
                    baddie.StartTypeSentence(baddie.introLines.sentences[1]);
                    break;
                case 4:
                    baddie.StartTypeSentence(baddie.introLines.sentences[2]);
                    break;
                case 5:
                    baddie.StartTypeSentence(baddie.introLines.sentences[3]);
                    break;
                case 6:
                    baddie.StartTypeSentence(baddie.introLines.sentences[4]);
                    baddie.SwitchFace(baddie.AngryFace);
                    break;
                case 7:
                    baddie.StartTypeSentence(baddie.introLines.sentences[5]);
                    baddie.SwitchFace(baddie.DefeatFace);
                    break;

            }
    }

    public override void UpdateState(BaddieStateManager baddie)
    {
        /*if(baddie.playerDiedDuringLevel.value == true)
        {
            baddie.SwitchState(baddie.InsultState);
        }*/
    }

    public override IEnumerator ImpatientTimer(BaddieStateManager baddie)
    {
        yield return new WaitForSeconds(7f);
        baddie.SwitchState(baddie.ImpatientState);

        //throw new System.NotImplementedException();
    }

}
