using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public TextMeshProUGUI puntajeText;
    public int puntaje;

    private void Awake()
    {
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        puntajeText.text = puntaje.ToString();
    }
}
