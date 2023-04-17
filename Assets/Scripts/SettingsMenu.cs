using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class SettingsMenu : MonoBehaviour
{
    public AudioMixer mainMixer;
    public Toggle fullscreenToggle;
    public Dropdown dropdown;
    public void OnResolutionChange(int index)
    {
        int width = 1080;
        int height = 1920;

        switch (index)
        {
            case 2:
                width = 1080;
                height = 1920;
                break;
            case 1:
                width = 720;
                height = 1280;
                break;
            case 0:
                width = 360;
                height = 640;
                break;
            default:
                break;
        }
        Screen.SetResolution(height, width, FullScreenMode.Windowed);
        /* if (fullscreenToggle.isOn)
         {
             Screen.SetResolution(width, height, FullScreenMode.FullScreenWindow);
         }
         else
         {
             Screen.SetResolution(width, height, FullScreenMode.Windowed);
         }*/
    }
    //Changes to fullscreen mode or not to fullscreen
    public static void SetFullScreen(bool isFullscreen)
    {
        Screen.fullScreen = isFullscreen;
    }
    //Sets game quality
    public static void SetQuality(int qualityIndex)
    {
        QualitySettings.SetQualityLevel(qualityIndex);
    }
    //Controls game Audio
    public void SetVolume(float volume) 
    {
        mainMixer.SetFloat("Volume", volume);
    }
}
