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
                    baddie.StartTypeSentence(baddie.introLines[0].sentence);
                    baddie.SwitchFace(baddie.introLines[0].Face);
                    break;
                case 3:
                    baddie.StartTypeSentence(baddie.introLines[1].sentence);
                    baddie.SwitchFace(baddie.introLines[1].Face);
                    break;
                case 4:
                    baddie.StartTypeSentence(baddie.introLines[2].sentence);
                    baddie.SwitchFace(baddie.introLines[2].Face);
                    break;
                case 5:
                    baddie.StartTypeSentence(baddie.introLines[3].sentence);
                    baddie.SwitchFace(baddie.introLines[3].Face);
                    break;
                case 6:
                    baddie.StartTypeSentence(baddie.introLines[4].sentence);
                    baddie.SwitchFace(baddie.introLines[4].Face);
                    break;
                case 7:
                    baddie.StartTypeSentence(baddie.introLines[5].sentence);
                    baddie.SwitchFace(baddie.introLines[5].Face);
                    break;

            }
    }

    public override void UpdateState(BaddieStateManager baddie)
    {

    }

    public override IEnumerator ImpatientTimer(BaddieStateManager baddie)
    {
        yield return new WaitForSeconds(7f);
        baddie.SwitchState(baddie.ImpatientState);


    }

}
