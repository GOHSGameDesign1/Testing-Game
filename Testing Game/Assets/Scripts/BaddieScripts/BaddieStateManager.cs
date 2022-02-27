using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BaddieStateManager : MonoBehaviour
{
    
    BaddieBaseState currentState;
    public BaddieIntroState IntroState = new BaddieIntroState();
    public BaddieInsultState InsultState = new BaddieInsultState();
    public BaddieImpatientState ImpatientState = new BaddieImpatientState();
    public BaddieMadState MadState = new BaddieMadState();

    public bool isLeaving = false;
    public GlobalBool playerDiedDuringLevel;

    public Text dialogueText;

    public string madString;
    public Sprite madFace;

    public SpriteRenderer spriteRenderer;

    public Sprite NeutralFace;
    public Sprite LaughingFace;
    public Sprite AngryFace;
    public Sprite SurprisedFace;
    public Sprite AnnoyedFace;
    public Sprite DefeatFace;

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

        StartCoroutine(currentState.CoroutineState(this));

    }

    // Update is called once per frame
    void Update()
    {
        //player = GameObject.Find("Player");
        currentState.UpdateState(this);
    }

    public void SwitchState(BaddieBaseState state)
    {
        currentState = state;
        state.EnterState(this);
        StartCoroutine(currentState.CoroutineState(this));
    }

    public void StartTypeSentence(string coroutineName)
    {
        StartCoroutine(currentState.TypeSentence(this, coroutineName));
    }

    public void SwitchToMadState(string dialogue, Sprite image)
    {
        madString = dialogue;
        madFace = image;
        currentState = MadState;
        MadState.EnterState(this);
        StartCoroutine(MadState.CoroutineState(this));
    }

    public void SwitchFace(Sprite image)
    {
        spriteRenderer.sprite = image;
    }

    public void Defeat()
    {
        madString = "OW, fine you win. I was never a REAL challenge anyways..";
        madFace = DefeatFace;
        currentState = MadState;
        MadState.EnterState(this);
    }
}
