using UnityEngine.Audio;
using System;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    // FIELDS
    public Sound[] sounds;
    public static AudioManager instance;
    public SFXScriptable SFX;

    private int counter = 0;

    // Start is called before the first frame update
    void Awake()
    {
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

        /*
        foreach(Sound s in sounds)
        {
            // Creates a AudioSource component in the Audio Manager
            // With the following properties
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;
            s.source.volume = s.volume;
            s.source.pitch = s.pitch;
            s.source.loop = s.loop;
            
        }
        */

        foreach (AudioClip clip in SFX.clips)
        {
            AudioSource source = gameObject.AddComponent<AudioSource>();
            source.clip = clip;
        }

    }

    private void Start()
    {
        // Play the main theme
        Play("Theme");
    }

    public void Play(string name)
    {
        // Seek the sound by its name
        // And then plays it
        Sound s = Array.Find(sounds, sound => sound.name == name);

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
}
