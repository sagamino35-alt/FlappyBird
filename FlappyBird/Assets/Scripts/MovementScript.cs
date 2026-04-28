using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class MovementScript : MonoBehaviour
{
    Rigidbody2D pRb;
    [SerializeField] float jumpForce = 2;
    InputAction jumpAction;


    void Start()
    {
        jumpAction = InputSystem.actions.FindAction("Jump");

        pRb = GetComponent<Rigidbody2D>();
        


    }

    // Update is called once per frame
    void Update()
    {
        if (jumpAction.WasPerformedThisFrame())
        {
            pRb.linearVelocityY = 0;
            pRb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        }

        
    }

    


}
