using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFactory : Factory
{
    [SerializeField] private GameObject enemyPrefab;

    public override IProduct GetProduct(Vector3 position)
    {
        //create new enemy at the specified position
        GameObject enemyObject = Instantiate(enemyPrefab, position, Quaternion.identity);

        //get the enemy script that implements IProduct
        IProduct enemy = enemyObject.GetComponent<IProduct>();

        //call the function to set up the enemy
        enemy.Initialize();

        return enemy;
    }
}
