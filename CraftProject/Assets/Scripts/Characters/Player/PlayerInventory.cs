using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInventory : MonoBehaviour
{
    public static PlayerInventory inventory;

    private List<Item> playerInventory = new List<Item>();

    // Start is called before the first frame update
    void Start()
    {
        
    }

    //When attached object is activated
    private void Awake()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static PlayerInventory Instance
    {
        get
        {
            //Check that only one instance of this class exists
            if (!inventory)
            {
                inventory = GameObject.FindObjectOfType<PlayerInventory>();
            }
            return inventory;
        }
    }

    //Get the inventory
    public List<Item> GetInventory()
    {
        return playerInventory;
    }

    //Get only filter of player inventory
    public List<Item> GetFilteredInventory(Item.ItemType type)
    {
        List<Item> filterList = new List<Item>();
        //Filter for all items that are of this type
        for (int i = 0; i < playerInventory.Count; i++)
        {
            if (playerInventory[i].type == type)
            {
                filterList.Add(playerInventory[i]);
            }
        }

        return filterList;
    }
}
