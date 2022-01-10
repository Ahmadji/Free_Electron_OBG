using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Key", menuName = "FreeElectron/Key")]
public class KeyScriptable : ScriptableObject
{
    [Header("Keys")]
    public KeyCode mainKey;
    public KeyCode pauseKey;
}
