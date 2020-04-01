using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputReceiver : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    //Get input for movement from player and send to appropriate context given state
    public virtual void GetMoveInput(InputValue value)
    {
        Vector2 input = value.Get<Vector2>();

        switch (InputStateHandler.currentState)
        {
            case InputStateHandler.CurrentControlState.Field:

                break;
            case InputStateHandler.CurrentControlState.Map:

                break;
            case InputStateHandler.CurrentControlState.Menu:

                break;
            default:

                break;
        }
    }
}
