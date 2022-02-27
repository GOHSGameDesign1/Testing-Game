using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BaddieIntroState : BaddieBaseState
{
    public string[] introLines = { "To pass my tests, get to the square", "Now do some jumping", "Can you make this final jump?", "Have fun walking aimlessly around in the maze.", "That's it! Prepare to get crushed!!! AAHAHAAHAHAHAHAHAH!!!!!", "Ok fine.. you win. I never was a REAL challenge anyways. Just get out of here ok..." };

    private int currentBuildIndex;

    public override void EnterState(BaddieStateManager baddie)
    {
        currentBuildIndex = SceneManager.GetActiveScene().buildIndex;

        if (baddie.playerDiedDuringLevel.value == true)
        {
            baddie.SwitchState(baddie.InsultState);
        }
        else
        {
            //Debug.Log(introLines[Random.Range(0, 3)]);
            //Debug.Log("INTRO STATE");

            //baddie.dialogueText.text = introLines[0];

            //baddie.StartTypeSentence(introLines[Random.Range(0,3)]);

            switch (currentBuildIndex)
            {
                case 2:
                    baddie.StartTypeSentence(introLines[0]);
                    baddie.SwitchFace(baddie.NeutralFace);
                    break;
                case 3:
                    baddie.StartTypeSentence(introLines[1]);
                    break;
                case 4:
                    baddie.StartTypeSentence(introLines[2]);
                    break;
                case 5:
                    baddie.StartTypeSentence(introLines[3]);
                    break;
                case 6:
                    baddie.StartTypeSentence(introLines[4]);
                    baddie.SwitchFace(baddie.AngryFace);
                    break;
                case 7:
                    baddie.StartTypeSentence(introLines[5]);
                    baddie.SwitchFace(baddie.DefeatFace);
                    break;

            }
        }

    }

    public override void UpdateState(BaddieStateManager baddie)
    {
        /*if(baddie.playerDiedDuringLevel.value == true)
        {
            baddie.SwitchState(baddie.InsultState);
        }*/
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
