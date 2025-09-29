using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Factory : MonoBehaviour
{
    //spawn point for the products
    public abstract IProduct GetProduct(Vector3 position);
}
