using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonReset : MonoBehaviour
{
    [SerializeField] List<Slider> sliders = new List<Slider>();
    void Start()
    {
        sliders[0].value = ManagerScript.instance.masterVol;
        sliders[1].value = ManagerScript.instance.musicVol;
        sliders[2].value = ManagerScript.instance.sfxVol;
    }
}
