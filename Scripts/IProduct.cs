using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IProduct
{
    string productName { get; set; }

    void Initialize();
}
