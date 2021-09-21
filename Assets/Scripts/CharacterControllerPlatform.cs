using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterControllerPlatform : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speedCharacter;
    
    public bool isGrounded = true;
    public Animator anim;
    [Header("Jump Mechanics")]
    [Range(1, 20)]
    public float strenghJump;
    public float fallMultiplier = 2.5f;
    public float lowJumpMultiplier = 2;

    [Header("Fx")]
    public ParticleSystem dust;
    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(x * speedCharacter * Time.deltaTime, rb.velocity.y) ;
        if(rb.velocity.x < 0)
        {
            transform.eulerAngles = new Vector3(0, 180, 0);
        }
        else if(rb.velocity.x > 0)
        {
            transform.eulerAngles = new Vector3(0, 0, 0);
        }
        anim.SetFloat("Speed", Mathf.Abs(rb.velocity.x));
        anim.SetInteger("Hp", GetComponent<Health>().health);

        if(Mathf.Abs(rb.velocity.x) > 0 && isGrounded)
        {
            if(dust.isStopped)
            {
                dust.Play();
            }            
        }
        else
        {
            if (!dust.isStopped)
            {
                dust.Stop();
            }
        }

        if(Input.GetButtonDown("Jump") && isGrounded)
        {
            Jump();
        }
        if(rb.velocity.y <0)
        {
            rb.velocity += Vector2.up * Physics2D.gravity.y * (fallMultiplier - 1) * Time.deltaTime;

        }
        else if(rb.velocity.y >0 && !Input.GetButton("Jump"))
        {
            rb.velocity += Vector2.up * Physics2D.gravity.y * (lowJumpMultiplier - 1) * Time.deltaTime;
        }


    }

    private void OnMouseDown()
    {
        GetComponent<Health>().TakeDamage(1);
    }

    public void Jump()
    {
        //rb.AddForce(Vector2.up * strenghJump);
        rb.velocity = Vector2.up * strenghJump;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Floor"))
        {
            isGrounded = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Floor"))
        {
            isGrounded = false;
        }
    }

}
