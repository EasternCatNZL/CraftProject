using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMenuInput : MonoBehaviour
{
    [Header("UI components")]
    public GameObject cursor = null;
    public GameObject pauseComponents = null;

    [Header("Input System")]
    public PlayerInput playerInput;
    public PlayerInputAction inputAction;

    //Currently controlled menu
    public MenuNavigator currentMenu = null;

    //Current menu item that is selected
    public MenuItem currentItem = null;

    //Singleton instance
    public static PlayerMenuInput playerMenuInput;

    //Input system controls
    private Vector2 movementInput;

    //Temp control
    bool menuOpen = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    //When attached object is activated
    private void Awake()
    {
        inputAction = new PlayerInputAction();
    }

    // Update is called once per frame
    void Update()
    {
        if (menuOpen)
        {
            if (currentMenu)
            {
                GetMoveInput(movementInput);
            }
        }           
    }

    private void OnEnable()
    {
        inputAction.Menu.Enable();

        inputAction.Game.Move.performed += Move;
        inputAction.Game.Move.performed += Confirm;
        inputAction.Game.Move.performed += Cancel;
        inputAction.Game.Move.performed += QuickUtility;
        inputAction.Game.Move.performed += DetailedUtility;
        inputAction.Game.Move.performed += PageUp;
        inputAction.Game.Move.performed += PageDown;
        inputAction.Game.Move.performed += ExitMenu;

        inputAction.Game.Move.Enable();
        inputAction.Game.Move.Enable();
        inputAction.Game.Move.Enable();
        inputAction.Game.Move.Enable();
        inputAction.Game.Move.Enable();
        inputAction.Game.Move.Enable();
        inputAction.Game.Move.Enable();
        inputAction.Game.Move.Enable();
    }

    private void OnDisable()
    {
        inputAction.Game.Move.performed -= Move;
        inputAction.Game.Move.performed -= Confirm;
        inputAction.Game.Move.performed -= Cancel;
        inputAction.Game.Move.performed -= QuickUtility;
        inputAction.Game.Move.performed -= DetailedUtility;
        inputAction.Game.Move.performed -= PageUp;
        inputAction.Game.Move.performed -= PageDown;
        inputAction.Game.Move.performed -= ExitMenu;

        inputAction.Game.Move.Disable();
        inputAction.Game.Move.Disable();
        inputAction.Game.Move.Disable();
        inputAction.Game.Move.Disable();
        inputAction.Game.Move.Disable();
        inputAction.Game.Move.Disable();
        inputAction.Game.Move.Disable();
        inputAction.Game.Move.Disable();

        inputAction.Menu.Disable();
    }

    private void ExitMenu(InputAction.CallbackContext obj)
    {
        if (currentMenu)
            currentMenu.ExitMenu();
    }

    private void PageDown(InputAction.CallbackContext obj)
    {
        if (currentMenu)
            currentMenu.PageDown();
    }

    private void PageUp(InputAction.CallbackContext obj)
    {
        if (currentMenu)
            currentMenu.PageUp();
    }

    private void DetailedUtility(InputAction.CallbackContext obj)
    {
        if (currentMenu)
            currentMenu.DetailedUtil();
    }

    private void QuickUtility(InputAction.CallbackContext obj)
    {
        if (currentMenu)
            currentMenu.QuickUtil();
    }

    private void Cancel(InputAction.CallbackContext obj)
    {
        if(currentMenu)
        currentMenu.Cancel();
    }

    private void Confirm(InputAction.CallbackContext obj)
    {
        if(currentItem)
        currentItem.Select();
    }

    private void Move(InputAction.CallbackContext obj)
    {
        movementInput = obj.ReadValue<Vector2>();
    }



    public static PlayerMenuInput Instance
    {
        get
        {
            //Check that only one instance of this class exists
            if (!playerMenuInput)
            {
                playerMenuInput = GameObject.FindObjectOfType<PlayerMenuInput>();
            }
            return playerMenuInput;
        }
    }

    //Set the current menu to be navigated
    public void SetCurrentMenu(MenuNavigator menu)
    {
        currentMenu = menu;
        menu.GetFirstItem();
    }

    //Recieve movement input from player and pass it on to menu navigation
    public void GetMoveInput(Vector2 input)
    {
        currentMenu.GetMoveInput(input);
    }

    //When player input for confirm is pressed
    public void ConfirmButton()
    {
        //Sends the call to the currently selected item
        currentItem.Highlighted();
    }
}
