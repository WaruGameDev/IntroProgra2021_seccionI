using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    public enum POWER_UP_TYPES
    {
        DOUBLE_CANON,
        MAX_SPEED,
        LASER
    }
    public POWER_UP_TYPES powerUp;
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Bullet"))
        {
            switch(powerUp)
            {
                case POWER_UP_TYPES.DOUBLE_CANON:
                    GameCanonManager.instance.doubleCanon = true;                   
                    break;
                case POWER_UP_TYPES.MAX_SPEED:
                    GameObject.FindGameObjectWithTag("Player")
                        .GetComponent<CanonController>().speedCanon *= 2;
                    break;
            }
            Destroy(other.gameObject);
            Destroy(gameObject);

        }
    }
}
