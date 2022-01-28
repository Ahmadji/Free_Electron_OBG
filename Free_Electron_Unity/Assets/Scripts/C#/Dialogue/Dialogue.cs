using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable] // So that the class appears in the inspector
public class Dialogue
{
    public string name;

    [TextArea(3, 10)]
    public string[] sentences;
}
