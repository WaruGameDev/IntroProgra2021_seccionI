using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepasoController : MonoBehaviour
{
    public int colorPlayer;
    private Renderer ren;
    public GameObject[] esferas;
    // Start is called before the first frame update

    public int numeroEntero;
    public float numeroDecimal;
    public bool booleanas;
    public string texto;
    
    void Start()
    {
        ShowData("inicio el start");
        ren = GetComponent<Renderer>();

        EjemploWhile();

        EjemploFor();
       
        foreach(GameObject esfera in esferas)
        {
            print("Holi");
            esfera.GetComponent<Renderer>().material.color = Color.green;
        }
        for (int i = 0; i < esferas.Length; i++)
        {
            if(i > 3)
            {
                esferas[i].GetComponent<Renderer>().material.color = Color.yellow;
            }
            else
            {
                esferas[i].GetComponent<Renderer>().material.color = Color.cyan;
            }
        }
        if (colorPlayer < 5)
        {
            ren.material.color = Color.red;
        }
        else if (colorPlayer < 10)
        {
            ren.material.color = Color.blue;
        }
        else
        {
            ren.material.color = Color.black;
        }
        ShowData("termino el start");
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Bullet"))
        {
            ren.material.color = Color.magenta;
            ManagerRepaso.instance.cubosAtravesados++;
        }
    }
    public void EjemploWhile()
    {
        while (colorPlayer < 5)
        {
            print("Menor que 5");
            colorPlayer++;
        }
    }
    public void EjemploFor()
    {
        for (int i = 0; i < 10; i++)
        {
            print("Index del loop " + i);
        }
    }
    public void ShowData(string data)
    {
        print(data);
    }
}
