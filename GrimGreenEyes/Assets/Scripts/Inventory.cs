using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    [SerializeField] private GameObject inventoryObject; //Objeto padre del panel del inventario
    [SerializeField] private List<InventorySlot> slotsList = new List<InventorySlot>(); //Almacena los SLOTS (objetos con botones) del inventario
    private Dictionary<Item, int> inventoryItems = new Dictionary<Item, int>(); //Lista de ITEMS que posee el jugador

    [SerializeField] private OptionsPanel optionsPanel;


    void Start() //Indexa todos los slots en una lista
    {
        foreach (Transform child in inventoryObject.transform)
        {
            slotsList.Add(child.GetComponent<InventorySlot>());
        }
        UpdateInventory();
    }
    
    public void UpdateInventory() //Aplica los ITEMS en el diccionario al GRID
    {
        foreach (InventorySlot slot in slotsList)
        {
            slot.ResetSlot();
        }

        int i = 0;
        foreach(KeyValuePair<Item, int> entry in inventoryItems)
        {
            slotsList[i].SetItemAndAmount(entry.Key, entry.Value);
            i++;
        }
    }


    public void AddItem(Item item) //Añade un item al diccionario (inventario). Si ese item ya existía, aumenta su cantidad en 1 unidad.
    {
        if (inventoryItems.ContainsKey(item))
        {
            inventoryItems[item] = inventoryItems[item] + 1;
        }
        else
        {
            inventoryItems.Add(item, 1);
        }
    }

    public void RemoveItem(Item item) //Reduce en 1 unidad la cantidad del item indicado. Si la cantidad llega a 0, el item es borrado de la lista.
    {
        if (!inventoryItems.ContainsKey(item))
        {
            Debug.Log("THE ITEM " + item.name + " DOES NOT EXIST IN THE INVENTORY");
            return;
        }

        inventoryItems[item] = inventoryItems[item] - 1;
        if(inventoryItems[item] <= 0)
        {
            inventoryItems.Remove(item);
        }
    }

    public void TestAddItem(Item item)
    {
        AddItem(item);
        UpdateInventory();
    }

    public void TestRemoveItem(Item item)
    {
        RemoveItem(item);
        UpdateInventory();
    }

    public void OpenOptionsPanel(Vector3 position)
    {
        optionsPanel.ShowOptionsPanel(position);
    }
}
