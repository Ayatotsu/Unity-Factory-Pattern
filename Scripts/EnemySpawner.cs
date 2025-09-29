using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private EnemyFactory enemyFactory;

    void Update()
    {
        //Press space to spawn an enemy
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //x,z,y = 0. ground level
            Vector3 spawnPosition = new Vector3(Random.Range(-6f, 6f), 0, Random.Range(-6f, 6f));

            enemyFactory.GetProduct(spawnPosition);
        }
    }
}
