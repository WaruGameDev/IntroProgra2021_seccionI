using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerRepaso : MonoBehaviour
{
    public static ManagerRepaso instance;
    public int cubosAtravesados;
    private void Awake()
    {
        instance = this;
    }
    
}
