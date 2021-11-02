using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanonController : MonoBehaviour
{
    public float speedCanon;
    public GameObject bullet;
    public Transform canon, apuntado;
    public float strenghtShoot = 500;
    public float limitX, limitY;    

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

        transform.Translate(Vector3.right * x * speedCanon * Time.deltaTime);
        transform.Translate(Vector3.up * y * speedCanon * Time.deltaTime);

        Vector3 pos = transform.position;
        pos.x = Mathf.Clamp(pos.x, -limitX, limitX);
        pos.y = Mathf.Clamp(pos.y, -limitY, limitY);
        transform.position = pos;

        if(Input.GetButtonDown("Jump"))
        {
            if(!GameCanonManager.instance.doubleCanon)
            {
                GameObject bulletGo = Instantiate(bullet, canon.position, Quaternion.identity);
                bulletGo.GetComponent<Rigidbody>().AddForce(canon.forward * strenghtShoot);
                Destroy(bulletGo, 10);
            }
            else
            {
                Vector2 newPos = canon.position;
                newPos.x = newPos.x - 1;
                GameObject bulletGo = Instantiate(bullet, newPos, Quaternion.identity);
                bulletGo.GetComponent<Rigidbody>().AddForce(canon.forward * strenghtShoot);
                newPos.x = newPos.x + 2;
                GameObject bulletGo2 = Instantiate(bullet, newPos, Quaternion.identity);
                bulletGo2.GetComponent<Rigidbody>().AddForce(canon.forward * strenghtShoot);
                Destroy(bulletGo, 10);
                Destroy(bulletGo2, 10);
            }
           
        }
        //Vector3 posApuntado = Camera.main.ScreenToViewportPoint(Input.mousePosition);
        //posApuntado.z = 3;
        //print(posApuntado);
        ////apuntado.localRotation.SetLookRotation(posApuntado, Vector3.up);
        //apuntado.LookAt(posApuntado);


    }
}
