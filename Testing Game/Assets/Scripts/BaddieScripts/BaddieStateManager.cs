using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BaddieStateManager : MonoBehaviour
{
    //STATE SETUP
    BaddieBaseState currentState;
    public BaddieIntroState IntroState = new BaddieIntroState();
    public BaddieInsultState InsultState = new BaddieInsultState();
    public BaddieImpatientState ImpatientState = new BaddieImpatientState();
    public BaddieMadState MadState = new BaddieMadState();

    //DEATH CHECK
    public GlobalBool playerDiedDuringLevel;

    // UI/DIALOGUE
    public Text dialogueText;
    //public Dialogue introLines;
    //public Dialogue insultLines;
    public Dialogue[] impatientLines;



    //Changeable mad string based on trigger, each trigger has a unique string. This gets set to that string whenever the trigger gets activated.
    [HideInInspector] public string madString;

    //SPRITES
    public SpriteRenderer spriteRenderer;
    public Sprite NeutralFace;
    public Sprite LaughingFace;
    public Sprite AngryFace;
    public Sprite SurprisedFace;
    public Sprite AnnoyedFace;
    public Sprite DefeatFace;
    [HideInInspector] public Sprite madFace;

    //AUDIO
    public AudioSource talkingAudio;

    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();

        //Sets IntroState to start on program start
        if (playerDiedDuringLevel.value == true)
        {
            currentState = InsultState;
        }
        else 
        {
            currentState = IntroState; 
        }

        // this means the context (This exact monobehavior)
        currentState.EnterState(this);

        StartCoroutine(currentState.ImpatientTimer(this));

    }

    // Update is called once per frame
    void Update()
    {
        //player = GameObject.Find("Player");
        currentState.UpdateState(this);
    }

    public void SwitchState(BaddieBaseState state)
    {
        StopAllCoroutines();
        currentState = state;
        state.EnterState(this);
        StartCoroutine(currentState.ImpatientTimer(this));
    }

    public void StartTypeSentence(string sentence)
    {
        StartCoroutine(TypeSentence(sentence));
    }

    IEnumerator TypeSentence(string sentence)
    {
        dialogueText.text = "";
        foreach (char letter in sentence.ToCharArray())
        {
            dialogueText.text += letter;
            talkingAudio.Play();
            yield return new WaitForSeconds(0.03f);

        }
        //yield return true;
    }

    public void SwitchToMadState(string dialogue, Sprite image)
    {
        madString = dialogue;
        madFace = image;
        currentState = MadState;
        MadState.EnterState(this);
        StartCoroutine(MadState.ImpatientTimer(this));
    }

    public void SwitchFace(Sprite image)
    {
        spriteRenderer.sprite = image;
    }

    public void Defeat()
    {
        madString = "OK, fine you win. I was never a REAL challenge anyways..";
        madFace = DefeatFace;
        currentState = MadState;
        MadState.EnterState(this);
    }
}
