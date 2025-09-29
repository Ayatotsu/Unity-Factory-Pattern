using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour, IProduct
{
    public string productName { get; set; }


    //initialize the enemies that is created
    public void Initialize() 
    {
        productName = "Enemy";
        Debug.Log(productName + " spawned at " + transform.position);
    }
}
