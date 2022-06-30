using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryScript : MonoBehaviour
{
    [SerializeField] private GameObject Inventory;
    [SerializeField] private bool isInventory = false;
    [SerializeField] private GameObject Content;

    void Start()
    {
        Inventory.SetActive(false);    
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.I))
        {
            isInventory = !isInventory;
            Inventory.SetActive(isInventory);
            Content.transform.localPosition = new Vector3(0, 0, 0);
        }
    }
}
