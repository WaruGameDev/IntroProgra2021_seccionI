using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HuasoMovimiento : MonoBehaviour
{
    public float speedCharacter = 5;
    public Rigidbody rb;
    public Animator anim;


    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

        //rb.velocity = new Vector3(x * speedCharacter * Time.deltaTime, y * speedCharacter * Time.deltaTime, rb.velocity.z);
        rb.MovePosition(transform.position + new Vector3(x, y, 0).normalized * Time.deltaTime * speedCharacter);
        anim.SetFloat("Speed", Mathf.Abs(rb.velocity.magnitude));

        if (Input.GetKeyDown(KeyCode.Space))
        {
            anim.SetInteger("Ebriedad", 1);
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            anim.SetInteger("Ebriedad", 2);
        }

    }
}
