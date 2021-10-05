using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Filter : MonoBehaviour
{
    public Transform filterCleanWater, filterDirtyWater;
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Water"))
        {
            if(other.GetComponent<WaterPropierties>().levelOfImpurity<WaterManager.instance.waterImpurityLevel)
            {
                other.transform.position = filterCleanWater.position;
                WaterManager.instance.AddWater(1, true);
            }
            else
            {
                other.transform.position = filterDirtyWater.position;
                WaterManager.instance.AddWater(1, false);
            }
            Destroy(other.gameObject, 3);
        }
    }
}
