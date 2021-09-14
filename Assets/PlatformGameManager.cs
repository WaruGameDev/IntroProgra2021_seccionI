using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformGameManager : MonoBehaviour
{
    public static PlatformGameManager instance;
    //public int vidasCharacter = 10;

    private void Awake()
    {
        instance = this;
    }
}
