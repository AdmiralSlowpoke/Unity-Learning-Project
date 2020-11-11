using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonsScript : MonoBehaviour
{
    public GameObject aboutWindow;
    public GameObject settingWindow;
    public void ClickOnNewGame()
    {
        SceneManager.LoadScene("Game");
    }
    public void ClickOnSettings()
    {
        settingWindow.SetActive(!settingWindow.activeSelf);
    }
    public void ClickOnAbout()
    {
        aboutWindow.SetActive(!aboutWindow.activeSelf);
    }
    public void ClickOnExit()
    {
        Application.Quit();
    }
}
