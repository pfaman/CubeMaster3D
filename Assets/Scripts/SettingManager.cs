using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingManager : MonoBehaviour
{
    public Toggle soundToggle;
    public Toggle musicToggle;
    public Toggle vibrationToggle;
    /*public AudioSource audioClipBlast;
    public AudioSource audioClipMusic;
    public AudioSource audioClipSwipeUp;*/
    public static SettingManager Instance;


    private void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
        }
    }

    private void Start()
    {
        soundToggle.isOn = true;
        musicToggle.isOn = true;
        vibrationToggle.isOn = true;


        SetSaveToggle(); 
    }
    public void SetSaveToggle()
    {
        if (PlayerPrefs.GetInt("SoundToggle") == 1)
        {
            soundToggle.isOn = true;
        }
        else
        {
            soundToggle.isOn = false;

        }

        if (PlayerPrefs.GetInt("MusicToggle") == 1)
        {
            musicToggle.isOn = true;
        }
        else
        {
            musicToggle.isOn = false;

        }

        if (PlayerPrefs.GetInt("VibrateToggle") == 1)
        {
            vibrationToggle.isOn = true;
        }
        else
        {
            vibrationToggle.isOn = false;

        }
    }

    public void SetMusicToggle()
    {
        if (musicToggle.isOn)
        {
            // FindObjectOfType<AudioManager>().Play("Theme");
            //musicToggle.isOn = false;
            Debug.Log("if SetMusicToggle");
            PlayerPrefs.SetInt("MusicToggle", 1);

        }
        else
        {
         //   FindObjectOfType<AudioManager>().Stop("Theme");
            Debug.Log(" else SetMusicToggle");
            PlayerPrefs.SetInt("MusicToggle", 0);

            //  musicToggle.isOn = true;
            //  AudioManager.Instance.StopSoundAsPerIndex(1);
        }
    }

    public void SetSoundToggle()
    {
        if (soundToggle.isOn)
        {
           // FindObjectOfType<AudioManager>().Play("Blast");
          //  FindObjectOfType<AudioManager>().Play("SwipeUp");
            Debug.Log("if SetSoundToggle");
            // soundToggle.isOn = false;
            PlayerPrefs.SetInt("SoundToggle", 1);

        }
        else
        {
            PlayerPrefs.SetInt("SoundToggle", 0);

            ///  FindObjectOfType<AudioManager>().Stop("Blast");
            ///  FindObjectOfType<AudioManager>().Stop("SwipeUp");
            Debug.Log("else SetSoundToggle");
         //   soundToggle.isOn = true;
         //   AudioManager.Instance.StopSoundAsPerIndex(0);

        }
    }

    public void SetVibrationToggle()
    {
        Debug.Log("SetVibrationToggle");

        if (vibrationToggle.isOn)
        {
            PlayerPrefs.SetInt("VibrateToggle", 1);
            //  vibrationToggle.isOn = false;

        }
        else
        {
            PlayerPrefs.SetInt("VibrateToggle", 0);

            //  vibrationToggle.isOn = true;

        }
    }



}
