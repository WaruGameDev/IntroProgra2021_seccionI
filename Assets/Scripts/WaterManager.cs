using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class WaterManager : MonoBehaviour
{
    public static WaterManager instance;
    public float waterImpurityLevel = 40;
    public GameObject water;
    public Transform originWater;
    public float waterFrecuency;
    public TextMeshProUGUI infoWater;
    public int cleanWater, dirtyWater;
    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        StartCoroutine(CreateWater());
        RefreshUI();
    }
    IEnumerator CreateWater()
    {
        while(true)
        {
            yield return new WaitForSeconds(waterFrecuency);
            Instantiate(water, originWater.position, Quaternion.identity);
        }
    }
    public void AddWater(int i, bool clean)
    {
        if(clean)
        {
            cleanWater += i;
        }
        else
        {
            dirtyWater += i;
        }
        RefreshUI();
    }
    public void RefreshUI()
    {
        infoWater.text = "Agua limpia: " + cleanWater + "." + "\n" +
            "Agua sucia: " + dirtyWater + ".";
    }

}
