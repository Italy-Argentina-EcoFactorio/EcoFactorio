using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneratorController : MonoBehaviour
{
    private int _baselvl = 1;
    [SerializeField]
    private int _workersInBuilding;
    // Start is called before the first frame update
    void Start()
    {
        if(gameObject.name.Contains("energy"))
        {
            StartCoroutine(energyGenerator());
        }

        if(gameObject.name.Contains("food"))
        {
            StartCoroutine(foodGenerator());
        }

        if(gameObject.name.Contains("water"))
        {
            StartCoroutine(waterGenerator());
        }
    }

    IEnumerator energyGenerator()
    {
        yield return new WaitForSeconds(.2f);
        statcon.totalEnergy += 1*_baselvl*_workersInBuilding;
        StartCoroutine(energyGenerator());
    }

    IEnumerator foodGenerator()
    {
        yield return new WaitForSeconds(.2f);
        statcon.totalFood += 1*_baselvl*_workersInBuilding;
        StartCoroutine(foodGenerator());
    }

    IEnumerator waterGenerator()
    {
        yield return new WaitForSeconds(.2f);
        statcon.totalWater += 1*_baselvl*_workersInBuilding;
        StartCoroutine(energyGenerator());
    }
}
