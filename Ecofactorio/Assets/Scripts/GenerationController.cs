using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneratorController : MonoBehaviour
{
    private int baselvl = 1;
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
        yield return new WaitForSeconds(5);
        statcon.totalEnergy += 10*baselvl;
        StartCoroutine(energyGenerator());
    }

    IEnumerator foodGenerator()
    {
        yield return new WaitForSeconds(5);
        statcon.totalFood += 10*baselvl;
        StartCoroutine(foodGenerator());
    }

    IEnumerator waterGenerator()
    {
        yield return new WaitForSeconds(5);
        statcon.totalWater += 10*baselvl;
        StartCoroutine(energyGenerator());
    }
}
