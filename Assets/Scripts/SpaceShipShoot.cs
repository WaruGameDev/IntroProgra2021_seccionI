using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceShipShoot : MonoBehaviour
{
    public GameObject bullet;
    public List<Transform> canones;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }
    void Shoot()
    {
        foreach(Transform canon in canones)
        {
            Instantiate(bullet, canon.position, Quaternion.identity);
        }
    }
}
