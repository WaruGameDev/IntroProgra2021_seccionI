using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootOject : MonoBehaviour
{
    public GameObject bullet;
    public Transform canon;
    public float strenghtShoot = 500;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }
    public void Shoot()
    {
        GameObject bulletGo = Instantiate(bullet, canon.position, canon.rotation);
        bulletGo.GetComponent<Rigidbody>().AddForce(canon.forward * strenghtShoot);
        Destroy(bulletGo, 3);
    }
}
