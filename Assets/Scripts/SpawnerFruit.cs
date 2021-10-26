using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerFruit : MonoBehaviour
{
    public GameObject fruits;
    public float timeToSpawn = 3;
    private void Start()
    {
        StartCoroutine(SpawnFruitRoutine());
    }
    private void SpawnFruit()
    {
        Vector3 randomPosition = new Vector3(Random.Range(transform.position.x - 5, transform.position.x + 5),
            transform.position.y, transform.position.z);
        Instantiate(fruits, randomPosition, Quaternion.identity);
    }
    IEnumerator SpawnFruitRoutine()
    {
        while(true)
        {
            yield return new WaitForSeconds(timeToSpawn);
            SpawnFruit();
            if(timeToSpawn> 0.3f)
            {
                timeToSpawn -= .3f;
            }
        }        
    }
}
