using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class MenuNavigator : MonoBehaviour
{
    [Header("Menu object management")]
    //All menu components
    public List<GameObject> menuObjectsList = new List<GameObject>();

    //Reference to first menu component that should be active
    public GameObject firstOpenMenuItem;

    //Ref to player when data needed to populate

    //Menu navigation ref
    private GameObject currentItem;

    float xInput = 0.0f;
    float yInput = 0.0f;

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

    }

    //Get input from 
    public virtual void GetMoveInput(InputValue value)
    {
        //Get the input values as x and y
        xInput = value.Get<Vector2>().x;
        yInput = value.Get<Vector2>().y;
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
