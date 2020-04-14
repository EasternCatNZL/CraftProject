using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryTile : MonoBehaviour
{
    //Ref to item this tile is holding
    private Item myItem;

    //Stored x y of the tile in grid
    [HideInInspector]
    public Vector2 gridPosition = Vector2.zero;

    //Neighbour tile logic
    public enum Direction
    {
        North,
        South,
        East,
        West
    }

    private InventoryTile northTile = null;
    private InventoryTile southTile = null;
    private InventoryTile eastTile = null;
    private InventoryTile westTile = null;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Set the x and y values of this tile
    public void SetCoords(int x, int y)
    {
        gridPosition.x = x;
        gridPosition.y = y;
    }

    //Set the item to this tile
    public void SetItem(Item item)
    {
        myItem = item;
    }

    //Set up neighbour logic
    public void SetNeighbour(InventoryTile nTile, InventoryTile sTile, InventoryTile eTile, InventoryTile wTile)
    {
        //If a tile was found for each side, set, otherwise leave null
        if (nTile)
        {
            northTile = nTile;
        }
        if (sTile)
        {
            southTile = sTile;
        }
        if (eTile)
        {
            eastTile = eTile;
        }
        if (wTile)
        {
            westTile = wTile;
        }
    }

    //Get the neighbour in given direction
    public InventoryTile GetNeighbour(Direction direction)
    {
        InventoryTile tile = null                   ;
        switch (direction)
        {
            case Direction.North:
                tile = northTile;
                break;
            case Direction.South:
                tile = southTile;
                break;
            case Direction.East:
                tile = eastTile;
                break;
            case Direction.West:
                tile = westTile;
                break;
        }
        return tile;
    }
}
