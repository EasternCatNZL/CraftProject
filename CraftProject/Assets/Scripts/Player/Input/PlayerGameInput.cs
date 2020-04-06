using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerGameInput : MonoBehaviour
{
    [Header("Player")]
    public PlayerMovement playerMovement;

    [Header("Input System")]
    public PlayerInput playerInput;
    public PlayerInputAction inputAction;
    public string menuMapName = "Menu";

    [Header("Menus")]
    MenuNavigator pauseMenu;

    //Singleton instance
    public static PlayerGameInput instance;

    //Input system controls
    Vector2 movementInput;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        GetMoveInput();
    }

    //When attached object is activated
    private void Awake()
    {
        inputAction = new PlayerInputAction();        
    }

    private void MenuButton(InputAction.CallbackContext obj)
    {
        MenuButtonPressed();
    }

    private void Move(InputAction.CallbackContext obj)
    {
        movementInput = obj.ReadValue<Vector2>();
    }

    private void OnEnable()
    {
        inputAction.Game.Enable();

        inputAction.Game.Move.performed += Move;
        inputAction.Game.Menu.performed += MenuButton;
        
        inputAction.Game.Move.Enable();
        inputAction.Game.Menu.Enable();
    }

    private void OnDisable()
    {
        inputAction.Game.Move.performed -= Move;
        inputAction.Game.Menu.performed -= MenuButton;
        inputAction.Game.Disable();
    }

    public static PlayerGameInput Instance
    {
        get
        {
            //Check that only one instance of this class exists
            if (!instance)
            {
                instance = GameObject.FindObjectOfType<PlayerGameInput>();
            }
            return instance;
        }
    }

    //Recieve movement input from player and pass it to character
    public void GetMoveInput()
    {
        playerMovement.MoveCharacter(movementInput);
        print("Recieved input");
    }

    //When menu button is pressed
    public void MenuButtonPressed()
    {
        //Switch map to use menu
        playerInput.SwitchCurrentActionMap(menuMapName);
        //Open the menu
        pauseMenu.OpenMenu();
        //Set players current menu to pause menu
        PlayerMenuInput.playerMenuInput.SetCurrentMenu(pauseMenu);
    }
}
