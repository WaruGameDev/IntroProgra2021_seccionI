using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecogerPistola : MonoBehaviour
{
    public Transform posPistola;
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Pistola"))
        {
            other.transform.position = posPistola.position;
            other.transform.SetParent(posPistola);
            other.transform.localRotation = Quaternion.Euler(0,0,0);
        }
    }
}
