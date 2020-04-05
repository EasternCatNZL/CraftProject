using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryNavigator : MenuNavigator
{
    //Try grid layout to handle all of this
    [Header("Spacing measurements")]
    public int numItemsPerRow = 5;
    public float tileRadius = 5.0f;
    public float spacingBetweenTiles = 5.0f;

    //Canvas tiles used for holding each inventory item
    [Header("Tile object")]
    public InventoryTile tile = null;
    private List<InventoryTile> inventoryTiles = new List<InventoryTile>();

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    //On open menu
    public override void OpenMenu()
    {
        base.OpenMenu();
        //Get the inventory from player inventory
        PopulateInventoryGrid(PlayerInventory.inventory.GetInventory());
    }

    //On close menu
    public override void CloseMenu()
    {
        //Clear the inventory list
        base.CloseMenu();
        //Set back to previous menu
        PlayerMenuInput.playerMenuInput.SetCurrentMenu(myParentMenu);
        PlayerMenuInput.playerMenuInput.currentItem = myParentItem;
    }

    //Populate inventory grid
    private void PopulateInventoryGrid(List<Item> itemList)
    {
        //Empty list to ensure nothing from previous use exists
        inventoryTiles.Clear();
        //Positioning controls
        int x = 1;
        int y = 1;

        //Create a grid to hold all items that need to go into this inventory grid
        for (int i = 0; i < itemList.Count; i++)
        {
            //Create tile to hold the item
            GameObject tileObject = Instantiate(tile.gameObject);
            //Set coord positioning of this tile
            tileObject.GetComponent<InventoryTile>().SetCoords(x, y);
            //Increment x for next tile
            x++;
            //If x is greater than tiles per row, reset to 1 and increment y
            if (x > numItemsPerRow)
            {
                x = 1;
                y++;
            }
            //Set the item to this tile
            tileObject.GetComponent<InventoryTile>().SetItem(itemList[i]);
            //Add to current tilesls list
            inventoryTiles.Add(tileObject.GetComponent<InventoryTile>());
        }

        //Once created all tiles, position and set neighbour logic
        SetUpGridLogic(inventoryTiles, y);
    }

    //Setup grid logic
    private void SetUpGridLogic(List<InventoryTile> tiles, int numOfRows)
    {
        //For all tiles
        for (int i = 0; i < tiles.Count; i++)
        {
            //Create ref to tile for easy management
            InventoryTile thisTile = tiles[i].GetComponent<InventoryTile>();
            //Create refs for all possible neighbour tiles to this tile
            InventoryTile nTile = null;
            InventoryTile sTile = null;
            InventoryTile eTile = null;
            InventoryTile wTile = null;
            //Check the tile for possible neighbours
            //North
            if (thisTile.gridPosition.y > 1)
            {
                for (int j = 0; j < tiles.Count; j++)
                {
                    if (thisTile.gridPosition.x == tiles[j].gridPosition.x &&
                        thisTile.gridPosition.y - 1 == tiles[j].gridPosition.y)
                    {
                        nTile = tiles[j].GetComponent<InventoryTile>();
                    }
                }
            }
            //South
            if (thisTile.gridPosition.y < numOfRows)
            {
                for (int j = 0; j < tiles.Count; j++)
                {
                    if (thisTile.gridPosition.x == tiles[j].gridPosition.x &&
                        thisTile.gridPosition.y - 1 == tiles[j].gridPosition.y)
                    {
                        sTile = tiles[j].GetComponent<InventoryTile>();
                    }
                }
            }
            //East
            if (thisTile.gridPosition.x < numItemsPerRow)
            {
                for (int j = 0; j < tiles.Count; j++)
                {
                    if (thisTile.gridPosition.x + 1 == tiles[j].gridPosition.x &&
                        thisTile.gridPosition.y == tiles[j].gridPosition.y)
                    {
                        eTile = tiles[j].GetComponent<InventoryTile>();
                    }
                }
            }
            //West
            if (thisTile.gridPosition.x > 1)
            {
                for (int j = 0; j < tiles.Count; j++)
                {
                    if (thisTile.gridPosition.x - 1 == tiles[j].gridPosition.x &&
                        thisTile.gridPosition.y == tiles[j].gridPosition.y)
                    {
                        wTile = tiles[j].GetComponent<InventoryTile>();
                    }
                }
            }

            //Assign the neighbours found to the tile
            thisTile.SetNeighbour(nTile, sTile, eTile, wTile);
        }
    }
}
