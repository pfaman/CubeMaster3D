using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public GameObject pausePanel;
    public GameObject gameOverPanel;
    public Button  pauseButtton;
    public TextMeshProUGUI bestScore;
    
    public TextMeshProUGUI currentScore;
    
    public static UIManager Instance;
    public int bestScoreValue;
    public int currentScoreValue;
    public int blastValue = 1;
    public int score = 0;

    private void Start()
    {

        if(Instance == null)
        {
            Instance = this;
        }
       // DontDestroyOnLoad(gameObject);

    }
    private void Update()
    {
        SetScore();
    }

    public void SetScore()
    {
        currentScore.text = score.ToString();
        PlayerPrefs.SetInt("CurrentScore", score);
        currentScoreValue = PlayerPrefs.GetInt("CurrentScore");
        if(currentScoreValue > bestScoreValue)
        {
            bestScoreValue = currentScoreValue;
            PlayerPrefs.SetInt("BestScore", bestScoreValue);
        }
        bestScoreValue = PlayerPrefs.GetInt("BestScore");
        bestScore.text = "Best Score: "+ bestScoreValue.ToString();


    }
    public void ShowPausePanel()
    {
        pausePanel.SetActive(true);
        Time.timeScale = 0;
        FindObjectOfType<AudioManager>().Stop("Theme");
    }

    public void ShowGameOverPanel()
    {
        gameOverPanel.SetActive(true);
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

        SceneManager.LoadScene("MainScene");
        Time.timeScale = 1;
        //pausePanel.SetActive(false);

        Debug.Log("Restart Button");
    }
    public void MenuButton()
    {
        SceneManager.LoadSceneAsync("MenuScene");
        Time.timeScale = 1;

       // pausePanel.SetActive(false);
        Debug.Log("Menu Button");
    }
}
