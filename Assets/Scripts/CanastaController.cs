using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanastaController : MonoBehaviour
{
    public float canastaSpeed = 10;


    private void Update()
    {
        float x = Input.GetAxis("Horizontal");

        transform.Translate(Vector2.right * canastaSpeed * x * Time.deltaTime);

    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Fruit"))
        {
            GameFruitManager.instance.AddPuntaje(other.GetComponent<Fruit>().puntaje);
            Destroy(other.gameObject);
        }
    }
}
