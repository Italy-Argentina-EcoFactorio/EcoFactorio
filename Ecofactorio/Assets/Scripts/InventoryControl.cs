using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryControl : MonoBehaviour
{
    
    public static int maxWeight = 100;
    public static int currentWeight;

    public static bool isOverencumberd { get { return currentWeight >= maxWeight; } }

    public static void AddResource(/*Something to decide which resource to pick, "int addWeight"*/)
    { 
        // currentWeight += (resource class).weight;
    }
}
