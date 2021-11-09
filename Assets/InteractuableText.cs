using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractuableText : MonoBehaviour
{
    public string textoAMostrar;
    public bool playerInZone;
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            playerInZone = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerInZone = false;
            ManagerInfo.instance.HideText();
        }
    }

    private void Update()
    {
        if(playerInZone && Input.GetButtonDown("Jump"))
        {
            ManagerInfo.instance.ShowText(textoAMostrar);
        }
            
    }

}
