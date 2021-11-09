using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ManagerInfo : MonoBehaviour
{
    public static ManagerInfo instance;
    public CanvasGroup panelInfo;
    public TextMeshProUGUI texto;

    private void Awake()
    {
        instance = this;
    }
    public void ShowText(string textoAMostrar)
    {
        panelInfo.alpha = 1;
        texto.text = textoAMostrar;
    }
    public void HideText()
    {
        panelInfo.alpha = 0;
        texto.text = "";
    }
}
