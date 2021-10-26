using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class AudioManager : MonoBehaviour
{
    public AudioMixer master;
    
    public void SetAudio(float vol)
    {
        float x;
        master.GetFloat("VolumeMaster", out x);
        master.SetFloat("VolumeMaster", x + vol);
    }
}
