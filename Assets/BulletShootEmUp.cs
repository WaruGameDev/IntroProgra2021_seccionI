using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletShootEmUp : MonoBehaviour
{
    public float speedBullet = 50;
    public Vector2 direction = new Vector2(0, 1);
    public float damage = 1;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, 3);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(direction * speedBullet * Time.deltaTime);
    }
}
