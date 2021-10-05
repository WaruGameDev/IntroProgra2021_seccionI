using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterPropierties : MonoBehaviour
{
    public float levelOfImpurity;
    public Material cleanWater, dirtyWater;
    public MeshRenderer mesh;

    private void Start()
    {
        levelOfImpurity = Random.Range(0, 100);
        if(levelOfImpurity < WaterManager.instance.waterImpurityLevel)
        {
            mesh.material = cleanWater;
        }
        else
        {
            mesh.material = dirtyWater;
        }
    }

}
