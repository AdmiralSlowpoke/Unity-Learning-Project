using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingsScript : MonoBehaviour
{
    public Resolution[] resolutions;
    public Text resolutionText;
    private int resolutionInt=0;
    private void Start()
    {
        resolutionText.text= PlayerPrefs.GetInt("Width").ToString() + "x" + PlayerPrefs.GetInt("Height").ToString();
        resolutionInt = PlayerPrefs.GetInt("ResolutionInt");
        gameObject.SetActive(false);
    }

    public void ClickOnResolutionLeft()
    {
        resolutionInt--;
        if (resolutionInt < 0)
            resolutionInt = resolutions.Length - 1;
        RefreshResolution();
    }
    public void ClickOnResolutionRight()
    {
        resolutionInt++;
        if (resolutionInt > resolutions.Length - 1)
            resolutionInt = 0;
        RefreshResolution();
    }
    private void RefreshResolution()
    {
        resolutionText.text = resolutions[resolutionInt].width.ToString() + "x" + resolutions[resolutionInt].height.ToString();
        PlayerPrefs.SetInt("Height", resolutions[resolutionInt].height);
        PlayerPrefs.SetInt("Width", resolutions[resolutionInt].width);
        PlayerPrefs.SetInt("ResolutionInt", resolutionInt);
    }
    public void ClickOnApplySettings()
    {
        Screen.SetResolution(resolutions[resolutionInt].width, resolutions[resolutionInt].height, true);
    }

}

[Serializable]
public class Resolution
{
    public int width;
    public int height;
}
