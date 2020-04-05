using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [Header("Movement")]
    public float moveSpeed = 5.0f;

    [Header("Components")]
    public Rigidbody2D myRigid;

    // Start is called before the first frame update
    void Start()
    {
        if (!myRigid)
        {
            myRigid = gameObject.GetComponent<Rigidbody2D>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Move the character given input
    public void MoveCharacter(Vector2 input)
    {
        myRigid.MovePosition(myRigid.position + (input * (moveSpeed * Time.deltaTime)));
    }
}
