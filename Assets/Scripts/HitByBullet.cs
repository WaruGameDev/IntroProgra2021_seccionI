using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitByBullet : MonoBehaviour
{
    public string tagBullet = "Bullet";
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag(tagBullet))
        {
            GetComponent<Health>().TakeDamage(collision.GetComponent<BulletShootEmUp>().damage);
            Destroy(collision.gameObject);
        }
    }
}
