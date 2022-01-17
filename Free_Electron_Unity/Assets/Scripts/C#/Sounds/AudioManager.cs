using UnityEngine.Audio;
using System;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    // FIELDS
    [SerializeField] private string backgroundMusic;
    public static AudioManager instance;
    public SFXScriptable SFX;
    public MusicScriptable Music;

    // Start is called before the first frame update
    void Awake()
    {
        /*
        if(instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }


        // So that the audio won't cut
        DontDestroyOnLoad(gameObject);
        */


        foreach(Sound s in SFX.sounds)
        {
            // Creates a AudioSource component in the Audio Manager
            // With the following properties
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;
            s.source.outputAudioMixerGroup = s.audioMixerGroup;
            s.source.volume = s.volume;
            s.source.pitch = s.pitch;
            s.source.loop = s.loop;
        }

        foreach (Sound m in Music.musics)
        {
            // Creates a AudioSource component in the Audio Manager
            // With the following properties
            m.source = gameObject.AddComponent<AudioSource>();
            m.source.clip = m.clip;
            m.source.outputAudioMixerGroup = m.audioMixerGroup;
            m.source.volume = m.volume;
            m.source.pitch = m.pitch;
            m.source.loop = m.loop;
        }
    }

    private void Start()
    {
        // Play the main theme
        PlayMusic(backgroundMusic);
    }

    public void PlaySFX(string name)
    {
        // Seek the sound by its name
        // And then plays it
        Sound s = Array.Find(SFX.sounds, sound => sound.name == name);

        if(s == null)
        {
            Debug.LogError("Sound : " + name + " not found!");
            return;
        }
        else
        {
            s.source.Play();
        }
    }

    public void PlayMusic(string name)
    {
        // Seek the sound by its name
        // And then plays it
        Sound m = Array.Find(Music.musics, music => music.name == name);

        if (m == null)
        {
            Debug.LogError("Music : " + name + " not found!");
            return;
        }
        else
        {
            m.source.Play();
        }
    }
}
