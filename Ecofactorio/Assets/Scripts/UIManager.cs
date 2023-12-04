using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
public class UIManager : MonoBehaviour
{
    // public GameObject inventoryMenu;
    public TextMeshProUGUI currentWeightText, energyCountText, foodCountText, waterCountText;

    // private bool invIsOpen;

    // Start is called before the first frame update
    void Start()
    {
        // inventoryMenu.SetActive(false);
        energyCountText.text = "Energy: " + statcon.totalEnergy.ToString();
        foodCountText.text = "Food: " + statcon.totalFood.ToString();
        waterCountText.text = "Water: " + statcon.totalWater.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        // if (Input.GetKeyDown(KeyCode.I))
        // {
        //     if (!invIsOpen)
        //     {
        //         Refresh();
        //         inventoryMenu.SetActive(true);
        //         invIsOpen = true;
        //     }
        //     else 
        //     {
        //         inventoryMenu.SetActive(false);
        //         invIsOpen = false;
        //     }
        // }
        Refresh();
    }

    void Refresh()
    {
        currentWeightText.text = $"Weight: {InventoryControl.currentWeight}";
        energyCountText.text = $"Energy: {statcon.totalEnergy}";
        foodCountText.text = $"Food: {statcon.totalFood}";
        waterCountText.text = $"Water: {statcon.totalWater}";
    }
}