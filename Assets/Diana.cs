using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Diana : MonoBehaviour
{
    public GameObject explosion;
    public float movementDistance = 2;
    public float timeMovement = .5f;
    public bool isMovible;
    public bool isVertical;
    

    private void Start()
    {
        if (isMovible)
        {
            if(!isVertical)
            {
                transform.DOMoveX(transform.position.x + movementDistance, timeMovement).
                SetLoops(-1, LoopType.Yoyo).
                SetEase(Ease.Linear);
            }
            else
            {
                transform.DOMoveY(transform.position.y + movementDistance, timeMovement).
                SetLoops(-1, LoopType.Yoyo).
                SetEase(Ease.Linear);
            }
            
        }    
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Bullet"))
        {
            Destroy(gameObject);
            Instantiate(explosion, transform.position, Quaternion.identity);
        }
    }
}
