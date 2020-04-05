using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuButtonLogic : MonoBehaviour
{
    [Header("Menu navigators")]
    public PauseMenuNavigator pauseMenu;
    public InventoryNavigator inventoryNavigator;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Pause menu buttons
    public void InventoryButton()
    {
        inventoryNavigator.OpenMenu();
    }

    public void OptionsButton()
    {

    }
}
