using System.Collections.Generic;
using UnityEngine;

public class ButtonScript : MonoBehaviour
{
    public AudioSource aud;
    public List<AudioClip> clips = new List<AudioClip>();
    void Start()
    {
        aud = GetComponent<AudioSource>();
    }
    public void GraphicsDropdown(int val)
    {
        if (val == 0)
        {
            ManagerScript.instance.graphicQuality = 0;
        }
        if (val == 1)
        {
            ManagerScript.instance.graphicQuality = 1;
        }
        if (val == 2)
        {
            ManagerScript.instance.graphicQuality = 2;
        }
        ManagerScript.instance.Graphics();
    }
    public void FPSDropdown(int val)
    {
        if (val == 0)
        {
            ManagerScript.instance.frameCap = 0;
        }
        if (val == 1)
        {
            ManagerScript.instance.frameCap = 1;
        }
        if (val == 2)
        {
            ManagerScript.instance.frameCap = 2;
        }
        ManagerScript.instance.FrameCap();
    }

    public void MasterVolumeButton(float val)
    {
        ManagerScript.instance.masterVol = val;
        if (val == -25)
        {
            ManagerScript.instance.masterVol = -100;
        }
        ManagerScript.instance.MasterVol();
    }
    public void MusicVolumeButton(float val)
    {
        ManagerScript.instance.musicVol = val;
        if (val == -25)
        {
            ManagerScript.instance.musicVol = -100;
        }
        ManagerScript.instance.MusicVol();
    }
    public void SfxVolumeButton(float val)
    {
        ManagerScript.instance.sfxVol = val;
        ManagerScript.instance.SfxVol();
    }
    
    public void ButtonSound(int i)
    {
        aud.PlayOneShot(clips[i], ManagerScript.instance.sfxVol);
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
