using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class MenuNavigator : MonoBehaviour
{
    [Header("Menu object management")]
    public GameObject myMenuGroup;
    public MenuNavigator myParentMenu = null;
    public MenuItem myParentItem = null;

    [Header("Menu display")]
    //Reference to first menu component that should be active
    public MenuItem firstOpenMenuItem;
    public List<MenuItem> menuItemList = new List<MenuItem>();

    [Header("Axis input requirements")]
    public float axisRequirement = 0.5f;

    //Ref to player when data needed to populate


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //On menu open
    public virtual void OpenMenu()
    {
        //Activate all menu items
        myMenuGroup.SetActive(true);
        //Get first item to be selected
        firstOpenMenuItem.gameObject.SetActive(true);
    }

    //On menu close
    public virtual void CloseMenu()
    {
        //Deactivate all menu items related
        myMenuGroup.SetActive(false);
        
        
    }

    //When an item is hovered over
    public void ItemHoveredOver(MenuItem item)
    {
        //Set player input controls
        PlayerMenuInput.Instance.currentItem = item;
        PlayerMenuInput.Instance.cursor.transform.position = item.transform.position;
        //Do item highlighted things
    }

    //Get first item that should be selected
    public virtual void GetFirstItem()
    {
        PlayerMenuInput.Instance.currentItem = firstOpenMenuItem;
        //Do this item hovered things
        ItemHoveredOver(firstOpenMenuItem);
    }

    //Get input from 
    public virtual void GetMoveInput(Vector2 input)
    {
        //Given the y input
        if (input.y > axisRequirement)
        {
            //Check if current item is first on list
            if (PlayerMenuInput.Instance.currentItem == menuItemList[0])
            {
                //Set to last
                PlayerMenuInput.Instance.currentItem = menuItemList[menuItemList.Count - 1].GetComponent<MenuItem>();
            }
            else
            {
                //Set to the previous item
                PlayerMenuInput.Instance.currentItem = menuItemList[menuItemList.IndexOf(PlayerMenuInput.Instance.currentItem) - 1].GetComponent<MenuItem>();
            }
        }
        else if (input.y < -axisRequirement)
        {
            //Check if current item is last on list
            if (PlayerMenuInput.Instance.currentItem == menuItemList[menuItemList.Count - 1])
            {
                PlayerMenuInput.Instance.currentItem = menuItemList[0].GetComponent<MenuItem>();
            }
            else
            {
                //Set to next item
                PlayerMenuInput.Instance.currentItem = menuItemList[menuItemList.IndexOf(PlayerMenuInput.Instance.currentItem) + 1].GetComponent<MenuItem>();
            }
        }
        //Move graphical component to where current item is
        ItemHoveredOver(PlayerMenuInput.Instance.currentItem);
    }

    //When menu option is confirmed
    public virtual void Confirm()
    {

    }

    //When cancel is inputted
    public virtual void Cancel()
    {

    }
}
