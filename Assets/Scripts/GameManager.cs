using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using DG.Tweening;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public TextMeshProUGUI puntajeText, timerText;
    public int puntaje;
    [Header("Time up Mechanics")]
    public float timer = 10;
    public CanvasGroup panelFeedback;
    public TextMeshProUGUI textoFeedback;

    private void Awake()
    {
        instance = this;
    }
    private void Start()
    {
        StartCoroutine(CountDown());
    }
    // Update is called once per frame
    void Update()
    {
        puntajeText.text = puntaje.ToString();
        timerText.text = ""+ (int)timer;
        //if (timer > 0)
        //{
        //    timer -= 1 * Time.deltaTime;
        //}
    }
    public void ShowPanelFeedback(string result)
    {
        textoFeedback.text = result;
        panelFeedback.DOFade(1, 0.5f);
    }

    public void ResetearLevel()
    {
        SceneManager.LoadScene(0);
    }

    IEnumerator CountDown()
    {
        while(timer > 0)
        {
            yield return new WaitForSeconds(1);
            timer--;
        }
        if(puntaje >9)
        {
            ShowPanelFeedback("Ganaste!");
        }
        else
        {
            ShowPanelFeedback("Perdiste :c");
        }
        // termina el contador
        yield break;
    }



}
