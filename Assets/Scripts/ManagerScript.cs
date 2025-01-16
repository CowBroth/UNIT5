using UnityEngine;
using UnityEngine.Audio;

public class ManagerScript : MonoBehaviour
{ 
    public static ManagerScript instance;

    public int graphicQuality;
    public int frameCap;

    public float masterVol;
    public float musicVol;
    public float sfxVol;

    public AudioMixer mixer;

    //GRASS TEXTURE
    //FLOWER
    //SCENE 1&2 EFFECTS
    //BUGFIX THROUGH PUBLISH

    void Start()
    {
        graphicQuality = 1;
        frameCap = 2;

        Graphics();
        FrameCap();
    }

    public void Graphics()
    {
        if (graphicQuality == 0)
        {
            QualitySettings.antiAliasing = 0;
        }
        if (graphicQuality == 1)
        {
            QualitySettings.antiAliasing = 2;
        }
        if (graphicQuality == 2)
        {
            QualitySettings.antiAliasing = 8;
        }
        print("AntiAliasing set to: " + QualitySettings.antiAliasing + "x");
    }
    public void FrameCap()
    {
        if (frameCap == 0)
        {
            Application.targetFrameRate = 60;
        }
        if (frameCap == 1)
        {
            Application.targetFrameRate = 120;
        }
        if (frameCap == 2)
        {
            Application.targetFrameRate = 0;
        }
        print("FrameRate Cap set to: " + Application.targetFrameRate);
    }

    public void MasterVol()
    {
        mixer.SetFloat("MasterVolume", masterVol);
    }
    public void MusicVol()
    {
        mixer.SetFloat("MusicVolume", musicVol);
    }
    public void SfxVol()
    {
        mixer.SetFloat("SFXVolume", sfxVol);
    }

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
