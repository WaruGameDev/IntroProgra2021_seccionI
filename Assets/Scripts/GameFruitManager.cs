using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameFruitManager : MonoBehaviour
{
    public static GameFruitManager instance;
    public int puntaje;
    public TextMeshProUGUI puntajeText;
    private void Awake()
    {
        instance = this;
    }
    private void Update()
    {
        puntajeText.text = puntaje.ToString();
    }
    public void AddPuntaje(int puntajeAAgregar)
    {
        puntaje += puntajeAAgregar;
    }
}
