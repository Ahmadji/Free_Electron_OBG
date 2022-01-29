using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

[System.Serializable] // So that the class appears in the inspector
public class Dialogue
{
    public string name;
    public TextMeshPro textMesh;

    [TextArea(3, 10)]
    public string[] sentences;
}
