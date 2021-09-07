using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coleccionable : MonoBehaviour
{
    public GameObject particles;
    public AudioSource sfx;
    

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            sfx.Play();
            GameManager.instance.puntaje++;
            Instantiate(particles, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
        
    }
    //private void OnTriggerExit(Collider other)
    //{
    //    if (other.CompareTag("Player"))
    //    {
    //        print("El gato salió del treat");
    //    }
    //}
    //private void OnTriggerStay(Collider other)
    //{
    //    if (other.CompareTag("Player"))
    //    {
    //        print("El gato esta en el treat");
    //    }
    //}
}
