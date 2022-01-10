using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Music", menuName = "FreeElectron/Music")]
public class MusicScriptable : ScriptableObject
{
    [Header("Musics")]
    public AudioClip mainMenuMusic;
    public AudioClip tutorialMusic;
    public AudioClip level1Music;
    public AudioClip level2Music;
    public AudioClip level3Music;
    public AudioClip level4Music;
    public AudioClip level5Music;
    public AudioClip gameOverMusic;
    public AudioClip gameWonMusic;
}
