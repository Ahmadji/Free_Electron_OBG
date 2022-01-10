using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "SFX", menuName = "FreeElectron/SFX")]
public class SFXScriptable : ScriptableObject
{
    [Header("In the Continuum")]
    public AudioClip continuumDoubleTap;
    public AudioClip continuumRotating;
    public AudioClip continuumMoving;

    [Header("Linked To Atom")]
    public AudioClip linkedDoubleTap;
    public AudioClip linkedOneTap;
    public AudioClip linkedRotating;
    public AudioClip linkedMoving;
    public AudioClip reloadingEnergy;
    public AudioClip collidingAlectron;
    public AudioClip expulsion;

    [Header("Checkpoints")]
    public AudioClip takingCP;

    [Header("Menu")]
    public AudioClip playButtonClick;
    public AudioClip exitButtonClick;
    public AudioClip buttonSelection;
    public AudioClip buttonClick;
    public AudioClip pauseMenuActivate;
    public AudioClip pauseMenuDeactivate;

}
