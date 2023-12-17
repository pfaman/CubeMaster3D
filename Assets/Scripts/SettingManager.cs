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
    


    private void Start()
    {
    }
    public void SetMusicToggle()
    {
        Debug.Log("SetMusicToggle");
        if (musicToggle.isOn)
        {

            
        }
        else
        {
          //  AudioManager.Instance.StopSoundAsPerIndex(1);
            //  musicToggle.transform.GetChild(0).GetChild(0).GetComponent<Image>().sprite = crossImage.sprite;
        }
    }

    public void SetSoundToggle()
    {

        if (soundToggle.isOn)
        {
            Debug.Log("if SetSoundToggle");

            soundToggle.isOn = false;
            //soundToggle.transform.GetChild(0).GetChild(0).GetComponent<Image>().sprite = tickImage.sprite;
        }
        else
        {
            Debug.Log("else SetSoundToggle");

         //   AudioManager.Instance.StopSoundAsPerIndex(0);

            // soundToggle.transform.GetChild(0).GetChild(0).GetComponent<Image>().sprite = crossImage.sprite;
        }
    }

    public void SetVibrationToggle()
    {
        Debug.Log("SetVibrationToggle");

        if (vibrationToggle.isOn)
        {
           
         //   vibrationToggle.transform.GetChild(0).GetChild(0).GetComponent<Image>().sprite = tickImage.sprite;
        }
        else
        {
            //vibrationToggle.transform.GetChild(0).GetChild(0).GetComponent<Image>().sprite = crossImage.sprite;
        }
    }

}
