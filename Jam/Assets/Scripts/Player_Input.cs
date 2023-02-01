using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player_Input : MonoBehaviour
{

    public Vector2 movement_direction { get; protected set; }
    public Vector2 mouse_rotation { get; protected set; }

    public void MouseInput(InputAction.CallbackContext context)
    {
        mouse_rotation = context.ReadValue<Vector2>().normalized;
    }

    public void MovementInput(InputAction.CallbackContext context) 
    {
       movement_direction = context.ReadValue<Vector2>().normalized;
    }
}
