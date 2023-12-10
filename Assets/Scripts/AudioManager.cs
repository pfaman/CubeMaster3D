using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using System;


public class AudioManager : MonoBehaviour
{
    public Sound[] sounds;

    private void Awake()
    {
        foreach(Sound s in sounds)
        {
            s.audioSource = gameObject.AddComponent<AudioSource>();
            s.audioSource.clip = s.audioCLip;
          //  s.audioSource.volume = s.volume;
            //s.audioSource.pitch = s.pitch;
            s.audioSource.loop = s.loop;

        }
    }
    private void Start()
    {
        Play("Theme");
    }

    public void Play(string name)
    {
        Sound s= Array.Find(sounds, sound => sound.name == name);
        s.audioSource.Play();
    }
    public void Stop(string name)
    {
        Sound s = Array.Find(sounds, sound => sound.name == name);
        s.audioSource.Stop();
    }
}
