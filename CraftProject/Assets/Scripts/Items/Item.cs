using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public enum ItemType
    {
        Material,
        Tool,
        Equipment,
        Key
    }

    public enum ItemTrait
    {
        Big,
        Small,
        Cheap,
        Expensive
    }

    [Header("Item traits")]
    public ItemType type = ItemType.Material;
    public List<ItemTrait> myTraits = new List<ItemTrait>();

    [Header("Visual")]
    public Sprite mySprite = null;
    private SpriteRenderer spriteRenderer = null;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
