using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverGatito : MonoBehaviour
{
    public Transform gatitoTransform;
    public float speedGatito=10;
    int test;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.RightArrow))
        {
            gatitoTransform.Translate(Vector3.right * Time.deltaTime * speedGatito);
        }
        if(Input.GetKey(KeyCode.LeftArrow))
        {
            gatitoTransform.Translate(Vector3.left * Time.deltaTime * speedGatito);
        }
        
    }
    private void OnMouseDown()
    {
        print("gato clickeado");
        MiMetodo();
        print(15 + CalculoVida());
        Suma(3,7.5f);
    }
    private void OnMouseDrag()
    {
        print("dragueando al gato");
    }
    private void OnMouseEnter()
    {
        print("Mouse toca al gato");
    }
    private void OnMouseExit()
    {
        print("sale del gato");
    }
    private void OnMouseOver()
    {
        print("Mouse sobre el gato");
    }
    private void OnMouseUp()
    {
        print("Suelta el click sobre el gato");
    }
    private void MiMetodo()
    {
        print("llame a mi metodo");
    }
    private string CalculoVida()
    {
        return "15";
    }
    public void Suma(float a, float b)
    {
        print(a + b);
    }

}
