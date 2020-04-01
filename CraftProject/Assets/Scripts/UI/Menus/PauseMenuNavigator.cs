using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PauseMenuNavigator : MenuNavigator
{
    [Header("Menu object management")]
    //All menu components
    public List<GameObject> menuObjectsList = new List<GameObject>();
    //Reference to menu backpanel
    public GameObject pauseMenuPanel;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Open the pause menu
    public void OpenMenu()
    {
        //Set pause menu and first menu item to active
        pauseMenuPanel.SetActive(true);
        firstOpenMenuItem.SetActive(true);
        //Set current input state to be on menu
        InputStateHandler.currentState = InputStateHandler.CurrentControlState.Menu;
        
    }

    //Close the menu and deactivate all menu components
    public void CloseMenu()
    {
        foreach(GameObject menuItem in menuObjectsList)
        {
            menuItem.SetActive(false);
        }
    }
}
