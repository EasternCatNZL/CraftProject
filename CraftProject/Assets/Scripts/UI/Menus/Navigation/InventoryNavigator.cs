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

    [Header("Inventory Canvas")]
    public GameObject inventoryGrid;
    public float baseX = 0.0f;
    public float baseY = 0.0f;
    //For easy reference
    private int lastX = 0;
    private int lastY = 0;

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
            //Create tile to hold the item, set parent to inventory grid in canvas
            GameObject tileObject = Instantiate(tile.gameObject, inventoryGrid.transform);
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
            //Position the tile given x y of grid
            float rectX = baseX + ((x - 1) * spacingBetweenTiles);
            float rectY = baseY + ((y - 1) * spacingBetweenTiles);
            tileObject.GetComponent<RectTransform>().anchoredPosition.Set(rectX, rectY);
        }

        //Set last x and y for easy ref later to find last row and col
        lastX = x;
        lastY = y;
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

    //Get input from player
    public override void GetMoveInput(Vector2 input)
    {
        //Get reference of the current inventory tile
        InventoryTile currentTile = PlayerMenuInput.Instance.currentItem.GetComponent<InventoryTile>();
        //Do horizontal
        //Is positive
        if (input.x > axisRequirement)
        {
            //Check if this tile has a east neighbour
            if (currentTile.GetNeighbour(InventoryTile.Direction.East))
            {
                //Set current to east neighbour
                PlayerMenuInput.Instance.currentItem = currentTile.GetNeighbour(InventoryTile.Direction.East).GetComponent<MenuItem>();
            }
            //Else, set to first in row
            else
            {
                //Set to first in row
                Vector2 target = new Vector2(1, currentTile.gridPosition.y);
                //Only do if more than one in row
                if(currentTile.gridPosition.x != 1)
                {
                    //Search for a tile that has the target
                    for(int i = 0; i < inventoryTiles.Count; i++)
                    {
                        if(inventoryTiles[i].gridPosition == target)
                        {
                            PlayerMenuInput.Instance.currentItem = inventoryTiles[i].GetComponent<MenuItem>();
                        }
                    }
                }
            }
        }
        //Is negative
        else if(input.x < -axisRequirement)
        {
            //Check tile has west neighbour
            if (currentTile.GetNeighbour(InventoryTile.Direction.West))
            {
                //Set current to west neighbour
                PlayerMenuInput.Instance.currentItem = currentTile.GetNeighbour(InventoryTile.Direction.East).GetComponent<MenuItem>();
            }
            //else set to last in row
            else
            {
                //If not last row
                if(currentTile.gridPosition.y < lastY)
                {
                    //get the tile in last position in same row
                    Vector2 target = new Vector2(5, currentTile.gridPosition.y);
                    //Search for a tile that has the target
                    for (int i = 0; i < inventoryTiles.Count; i++)
                    {
                        if (inventoryTiles[i].gridPosition == target)
                        {
                            PlayerMenuInput.Instance.currentItem = inventoryTiles[i].GetComponent<MenuItem>();
                        }
                    }
                }
                //else in last row
                else
                {
                    //Get the last tile
                    Vector2 target = new Vector2(lastX, lastY);
                    //Search for a tile that has the target coord
                    for (int i = 0; i < inventoryTiles.Count; i++)
                    {
                        if (inventoryTiles[i].gridPosition == target)
                        {
                            PlayerMenuInput.Instance.currentItem = inventoryTiles[i].GetComponent<MenuItem>();
                        }
                    }
                }
            }
        }

        //Do Vertical
        //Is positive
        if(input.y > axisRequirement)
        {
            //Check if tile has north neighbour
            if (currentTile.GetNeighbour(InventoryTile.Direction.North))
            {
                //Set current to north neighbour
                PlayerMenuInput.Instance.currentItem = currentTile.GetNeighbour(InventoryTile.Direction.North).GetComponent<MenuItem>();
            }
            //else get bottom tile in same column
            else
            {
                //Only if there is more than one row
                if(lastY > 1)
                {
                    Vector2 target = Vector2.zero;
                    //if current x is greater than last x, target is current x current y -1
                    if(currentTile.gridPosition.x > lastX)
                    {
                        target = new Vector2(currentTile.gridPosition.x, currentTile.gridPosition.y - 1);

                    }
                    //else take same x in last row
                    else
                    {
                        target = new Vector2(currentTile.gridPosition.x, currentTile.gridPosition.y);
                    }
                    //Search for a tile that has the target
                    for (int i = 0; i < inventoryTiles.Count; i++)
                    {
                        if (inventoryTiles[i].gridPosition == target)
                        {
                            PlayerMenuInput.Instance.currentItem = inventoryTiles[i].GetComponent<MenuItem>();
                        }
                    }
                }
            }
        }
        //Is negative
        else if(input.y < -axisRequirement)
        {
            //Check if tile has south neighbour
            if (currentTile.GetNeighbour(InventoryTile.Direction.South))
            {
                //Set current to south neighbour
                PlayerMenuInput.Instance.currentItem = currentTile.GetNeighbour(InventoryTile.Direction.South).GetComponent<MenuItem>();
            }
            //Else, get same x in first row
            else
            {
                //Only do if more than one row
                if(currentTile.gridPosition.y > lastY)
                {
                    Vector2 target = new Vector2(currentTile.gridPosition.x, 1);
                    //Search for a tile that has the target
                    for (int i = 0; i < inventoryTiles.Count; i++)
                    {
                        if (inventoryTiles[i].gridPosition == target)
                        {
                            PlayerMenuInput.Instance.currentItem = inventoryTiles[i].GetComponent<MenuItem>();
                        }
                    }
                }
            }
        }

        //Move graphical component to where current item is
        ItemHoveredOver(PlayerMenuInput.Instance.currentItem);
    }
}
