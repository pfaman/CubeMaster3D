using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public GameObject pausePanel;
    public Button  pauseButtton;
    public Button closeButton;

    public void ShowPausePanel()
    {
        pausePanel.SetActive(true);
        Time.timeScale = 0;
        FindObjectOfType<AudioManager>().Stop("Theme");
    }
    public void HidePausePanel()
    {
        pausePanel.SetActive(false);
    }
    public void ResumeButton()
    {
        FindObjectOfType<AudioManager>().Play("Theme");
        Time.timeScale = 1;
        pausePanel.SetActive(false);
    }
    public void RestartButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
       // pausePanel.SetActive(false);

        Debug.Log("Restart Button");
    }
    public void MenuButton()
    {
        SceneManager.LoadSceneAsync("MenuScene");
        pausePanel.SetActive(false);
        Debug.Log("Menu Button");
    }
}
