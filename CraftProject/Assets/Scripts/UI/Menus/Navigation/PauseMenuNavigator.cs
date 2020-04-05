using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PauseMenuNavigator : MenuNavigator
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public override void OpenMenu()
    {
        base.OpenMenu();

        //Set current input state to be on menu
        InputStateHandler.currentState = InputStateHandler.CurrentControlState.Menu;
    }

    public override void CloseMenu()
    {
        base.CloseMenu();

        //Set current input state back to game
        InputStateHandler.currentState = InputStateHandler.CurrentControlState.Field;
    }
}
