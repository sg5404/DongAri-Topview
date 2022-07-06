using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryScript : MonoBehaviour
{
    [SerializeField] private GameObject Inventory;
    [SerializeField] private bool isInventory = false;
    [SerializeField] private GameObject Content;
    [SerializeField] private GameObject Shop;
    [SerializeField] private bool isShop = false;

    void Start()
    {
        Inventory.SetActive(false);
        Shop.SetActive(false);
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.I))
        {
            isInventory = !isInventory;
            Inventory.SetActive(isInventory);
            Content.transform.localPosition = new Vector3(0, 0, 0);
        }
        if(Input.GetKeyDown(KeyCode.G))
        {
            isShop = !isShop;
            isInventory = isShop;
            Inventory.SetActive(isInventory);
            Shop.SetActive(isShop);
            Content.transform.localPosition = new Vector3(0, 0, 0);
        }
    }
}
