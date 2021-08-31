using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class MoverGatito : MonoBehaviour
{
    public Transform gatitoTransform;
    public float speedGatito = 10;
    public int hp;
    public SpriteRenderer theRen;



    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            gatitoTransform.Translate(Vector3.right * Time.deltaTime * speedGatito);
            theRen.flipX = true;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            gatitoTransform.Translate(Vector3.left * Time.deltaTime * speedGatito);
            theRen.flipX = false;
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            gatitoTransform.Translate(Vector3.up * Time.deltaTime * speedGatito);            
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            gatitoTransform.Translate(Vector3.down * Time.deltaTime * speedGatito);            
        }

    }
    private void OnMouseDown()
    {
        print("gato clickeado");
        TakeDamage();
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
    public void TakeDamage()
    {
        hp--;
        if (hp <= 0)
        {
            Destroy(gameObject);
        }
        else if (hp < 3)
        {
            transform.DOShakePosition(.5f);
        }
        else
        {
            transform.DOShakeRotation(.5f);
        }

    }
    //operaciones aritmeticas.
    // + - / * %
    // Mathf
    // "hola" + " " + "mundo" = "hola mundo"
    //operadores de comparación.
    // < > <= >= == !=
    // 3 != 4 =>  true
    // 5 < 3  => false
    // 3 <= 3  => true 
    // operadores lógicos
    // && ||  T F
    // T && T => true
    // T && F => false
    // T || T => true
    // T || F => true
    // if( 3 == 3 && 2< 1) => false
    // if (3 == 3 || 2 < 1) => true
    // if (3== 3 || 2 < 1 && 3> 2) => true
    // if (T || F && T)
    // if (T && T) 
}
