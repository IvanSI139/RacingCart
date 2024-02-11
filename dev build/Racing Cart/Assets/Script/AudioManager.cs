using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class AudioManager : MonoBehaviour
{
    public static AudioManager instance;
    public Sound[] musicSounds;
    public AudioSource musicSource;

    public void PlayMusic(string name)
    {
        Sound s = Array.Find(musicSounds, x=> x.name == name);

        if (s == null)
        {
            Debug.Log("No sound found.");
        }
        else
        {
            musicSource.clip = s.clip;
            musicSource.Play();
        }
    }
    private void Start()
    {
        PlayMusic("Theme");
    }

    // Set the volume of the audio source
    public void SetVolume(float volume)
    {
        musicSource.volume = volume;
    }

    // Get the current volume of the audio source
    public float GetVolume()
    {
        return musicSource.volume;
    }
}

