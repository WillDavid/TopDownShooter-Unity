using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpwanManager : MonoBehaviour
{
    
    [SerializeField] Transform[] spawnPoints;
    [SerializeField] GameObject enemy;



    
    void Start()
    {
        InvokeRepeating("SpwanEnemies", 1f, 1f);
    }

    void SpwanEnemies(){

        int index = Random.Range(0, spawnPoints.Length);
        Instantiate(enemy, spawnPoints[index].position, Quaternion.identity);
    }
}
