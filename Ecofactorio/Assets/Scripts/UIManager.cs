using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public GameObject inventoryMenu;
    public TextMeshProUGUI currentWeightText, energyCountText, foodCountText, waterCountText;

    private bool invIsOpen;

    // Start is called before the first frame update
    void Start()
    {
        inventoryMenu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            if (!invIsOpen)
            {
                Refresh();
                inventoryMenu.SetActive(true);
                invIsOpen = true;
            }
            else 
            {
                inventoryMenu.SetActive(false);
                invIsOpen = false;
            }
        }
    }

    void Refresh()
    {
        currentWeightText.text = $"Weight: {InventoryControl.currentWeight}";
        // waterCountText.text = $"Water: {InventoryControl.resources.energy}";
        // energyCountText.text = $"Energy: {InventoryControl.energyCount}";
        // foodCountText.text = $"Food: {InventoryControl.foodCount}";
    }
}