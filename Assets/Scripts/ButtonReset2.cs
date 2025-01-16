using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ButtonReset2 : MonoBehaviour
{
    [SerializeField] List<TMP_Dropdown> drop = new List<TMP_Dropdown>();
    void Start()
    {
        drop[0].value = ManagerScript.instance.graphicQuality;
        drop[1].value = ManagerScript.instance.frameCap;
    }
}
