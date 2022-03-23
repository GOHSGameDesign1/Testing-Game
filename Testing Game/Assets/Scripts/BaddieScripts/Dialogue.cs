using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Dialogue
{
    public Sprite Face;
    [TextArea(3,10)]
    public string sentence;
}
