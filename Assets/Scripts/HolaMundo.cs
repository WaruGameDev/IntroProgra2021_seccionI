using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HolaMundo : MonoBehaviour
{
    public int edadPersonaje = 50;
    public float altura;
    public bool hambre;
    public string nombre;
    public float velocidadDeGiro = 50;
    [SerializeField]
    private int variableEscondida;
    public Camera cameraTest;

    public Transform theTransform;
    // Start is called before the first frame update
    void Start()
    {
        cameraTest.backgroundColor = Color.green;
    }

    // Update is called once per frame
    void Update()
    {

        theTransform.Rotate(transform.up * velocidadDeGiro * Time.deltaTime);

    }
    
    

}
