using UnityEngine;
using TMPro;

public class SettingScript : MonoBehaviour
{
    public GameObject parent;
    public TMP_Dropdown graphicsDropdown;
    public TMP_Dropdown frameDropdown;
    void Start()
    {
        graphicsDropdown = parent.GetComponent<TMP_Dropdown>();
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
    public void FramerateDropdown()
    {
        if (frameDropdown.value == 0)
        {
            ManagerScript.instance.frameCap = 60;
        }
        if (frameDropdown.value == 1)
        {
            ManagerScript.instance.frameCap = 120;
        }
        if (frameDropdown.value == 2)
        {
            ManagerScript.instance.frameCap = 200;
        }
        if (frameDropdown.value == 3)
        {
            ManagerScript.instance.frameCap = 0;
        }

        ManagerScript.instance.FrameCap();
    }
}
