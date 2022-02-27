using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerGameBreak : MonoBehaviour
{
    public string triggerDialogue;
    public Sprite triggerFace;
    private BaddieStateManager baddieStateManager;
    // Start is called before the first frame update
    void Start()
    {
        baddieStateManager = GameObject.Find("Baddie").GetComponent<BaddieStateManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        baddieStateManager.StopAllCoroutines();
        baddieStateManager.SwitchToMadState(triggerDialogue, triggerFace);
        gameObject.SetActive(false);
    }
}
