using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{
    public GameObject settingPanel;
    public Button settingButton;
    // Start is called before the first frame update
    public void PlayButton()
    {
        SceneManager.LoadScene(2);
    }
    public void MoreGames()
    {
        Application.OpenURL("https://play.google.com/store/apps/dev?id=8094495406725672456&hl=en-IN");
    }
    public void RateUs()
    {
        Application.OpenURL("market://details?id=" + Application.identifier);

    }

    public void SettingPanelOpen()
    {
        settingPanel.SetActive(true);
    }

    public void SettingPanelClose()
    {
        settingPanel.SetActive(false);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
