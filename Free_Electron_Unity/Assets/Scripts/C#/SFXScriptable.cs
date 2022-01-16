using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "SFX", menuName = "FreeElectron/SFX")]
public class SFXScriptable : ScriptableObject
{
    [Header("Localized Sounds")]
    [Header("Checkpoints")]
    public AudioClip takingCP;

    
    public Sound[] sounds;
}
