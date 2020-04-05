using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputStateHandler : MonoBehaviour
{
    //Possible states that the game can be in
    public enum CurrentControlState
    {
        Map,
        Menu,
        Field
    }

    //The current state that the game is in, used by all components that need to respond to input
    public static CurrentControlState currentState = CurrentControlState.Menu;

    //Singleton instance of self
    public static InputStateHandler handler;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //When attached object is activated
    private void Awake()
    {

    }

    public static void ChangeGameState(CurrentControlState newState)
    {
        currentState = newState;
    }
}
