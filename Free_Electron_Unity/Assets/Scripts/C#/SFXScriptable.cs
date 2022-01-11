using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "SFX", menuName = "FreeElectron/SFX")]
public class SFXScriptable : ScriptableObject
{
    /*
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


    public AudioClip[] clips;
    */

    /*
    [Header("In the Continuum")]
    public Sound continuumDoubleTap;
    public Sound continuumRotating;
    public Sound continuumMoving;

    [Header("Linked To Atom")]
    public Sound linkedDoubleTap;
    public Sound linkedOneTap;
    public Sound linkedRotating;
    public Sound linkedMoving;
    public Sound reloadingEnergy;
    public Sound collidingAlectron;
    public Sound expulsion;

    [Header("Checkpoints")]
    public Sound takingCP;

    [Header("Menu")]
    public Sound playButtonClick;
    public Sound exitButtonClick;
    public Sound buttonSelection;
    public Sound buttonClick;
    public Sound pauseMenuActivate;
    public Sound pauseMenuDeactivate;
    */

    
    public Sound[] sounds;

    /*
    private void OnValidate()
    {
        
        clips = new AudioClip[] {
        continuumDoubleTap, continuumRotating, continuumMoving,
        linkedDoubleTap, linkedOneTap, linkedRotating, linkedMoving, reloadingEnergy, collidingAlectron, expulsion,
        takingCP,
        playButtonClick, exitButtonClick, buttonSelection, buttonClick, pauseMenuActivate, pauseMenuDeactivate};
        

        
        sounds = new Sound[] {
        continuumDoubleTap, continuumRotating, continuumMoving,
        linkedDoubleTap, linkedOneTap, linkedRotating, linkedMoving, reloadingEnergy, collidingAlectron, expulsion,
        takingCP,
        playButtonClick, exitButtonClick, buttonSelection, buttonClick, pauseMenuActivate, pauseMenuDeactivate};
        
    }
    */

}
