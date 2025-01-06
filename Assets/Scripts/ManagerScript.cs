using UnityEngine;

public class ManagerScript : MonoBehaviour
{ 
    public static ManagerScript instance;

    public int graphicQuality;
    public int frameCap;
    public bool toggle;

    public float masterVol;
    public float musicVol;
    public float sfxVol;

    void Start()
    {
        Application.targetFrameRate = 60;
        QualitySettings.antiAliasing = 2;
    }

    public void Graphics()
    {
        QualitySettings.antiAliasing = graphicQuality;
        print("AntiAliasing set to: " + QualitySettings.antiAliasing + "x");
    }
    public void FrameCap()
    {
        Application.targetFrameRate = frameCap;
        print("FrameRate Cap set to: " + Application.targetFrameRate);
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

    //problems !!!
    //scene changing resets dropdown references
    //framerate determines camera turning

    
}
