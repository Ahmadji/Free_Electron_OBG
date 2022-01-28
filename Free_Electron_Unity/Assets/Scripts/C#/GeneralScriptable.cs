using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "General", menuName = "FreeElectron/General")]
public class GeneralScriptable : ScriptableObject
{
    [Header("General")]
    public bool canLose;
    public bool canPause;
    public bool isTimeRunning;

    [Header("Continuum")]
    public bool canPlayerDoubleTapContinuum;
    public bool canPlayerHoldContinuum;
    [Header("Linked")]
    public bool canPlayerDoubleTapLinked;
    public bool canPlayerToggleLinked;
    public bool canPlayerOneTapLinked;
}
