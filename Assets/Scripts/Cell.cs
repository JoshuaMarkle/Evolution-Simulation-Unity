using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cell : Creature 
{
    protected override void Awake()
    {
        base.Awake();
        foodType = "Food";
    }
}
