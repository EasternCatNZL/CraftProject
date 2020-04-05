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
    MenuNavigator currentMenu = null;

    //Current menu item that is selected
    public MenuItem currentItem = null;

    //Singleton instance
    public static PlayerMenuInput playerMenuInput;

    //Input system controls
    private Vector2 movementInput;

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
    }

    private void ExitMenu(InputAction.CallbackContext obj)
    {
        throw new NotImplementedException();
    }

    private void PageDown(InputAction.CallbackContext obj)
    {
        throw new NotImplementedException();
    }

    private void PageUp(InputAction.CallbackContext obj)
    {
        throw new NotImplementedException();
    }

    private void DetailedUtility(InputAction.CallbackContext obj)
    {
        throw new NotImplementedException();
    }

    private void QuickUtility(InputAction.CallbackContext obj)
    {
        throw new NotImplementedException();
    }

    private void Cancel(InputAction.CallbackContext obj)
    {
        throw new NotImplementedException();
    }

    private void Confirm(InputAction.CallbackContext obj)
    {
        throw new NotImplementedException();
    }

    private void Move(InputAction.CallbackContext obj)
    {
        throw new NotImplementedException();
    }

    private void OnDisable()
    {
        inputAction.Menu.Disable();
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
    public void GetMoveInput(InputValue playerInput)
    {
        Vector2 input = playerInput.Get<Vector2>();
        currentMenu.GetMoveInput(input);
    }

    //When player input for confirm is pressed
    public void ConfirmButton()
    {
        //Sends the call to the currently selected item
        currentItem.Selected();
    }
}
