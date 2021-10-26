using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicEnemy : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speedEnemy = 50;
    public float x = 1;    

    // Update is called once per frame
    void Update()
    {       
        rb.velocity = new Vector2(x * speedEnemy * Time.deltaTime, rb.velocity.y);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Waypoint"))
        {
            x *= -1;
        }
    }
}
