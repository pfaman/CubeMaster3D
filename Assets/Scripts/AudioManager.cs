using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using System;


public class AudioManager : MonoBehaviour
{
    public Sound[] sounds;
   // public static AudioManager Instance;

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
        /*if (Instance == null)
        {
            Instance = this;
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }*/
        if (SettingManager.Instance != null) {
            if (SettingManager.Instance.musicToggle.isOn)
            {
                Play("Theme");

            }
        }
        else
        {
            Play("Theme");

        }
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

    public void StopSoundAsPerIndex(int index)
    {
        if(index==0){
            Stop("Blast");
            Stop("SwipeUp");
        }
        else
        {
            Stop("Theme");
        }
    }
}
