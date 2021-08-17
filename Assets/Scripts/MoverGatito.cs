using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverGatito : MonoBehaviour
{
    public Transform gatitoTransform;
    public float speedGatito=10;
    // Start is called before the first frame update
    void Start()
    {
        
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
}
