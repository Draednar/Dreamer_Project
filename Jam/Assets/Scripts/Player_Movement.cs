using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour
{
    [SerializeField] float move_speed = 100f, horizontal_mouse_speed = 100f, vertical_mouse_speed = 100;

    Player_Input input;
    Rigidbody rb;
    Vector3 direction, rotation;

    void Start()
    {
        input = GetComponent<Player_Input>();
        rb = GetComponent<Rigidbody>();
        rotation = transform.eulerAngles;
    }



    private void FixedUpdate()
    {
        rotation += new Vector3(-input.mouse_rotation.y * horizontal_mouse_speed, input.mouse_rotation.x * vertical_mouse_speed, 0f) * Time.deltaTime;
        transform.eulerAngles = rotation;
        direction = transform.forward * input.movement_direction.y + transform.right * input.movement_direction.x;
        rb.velocity = (direction * move_speed) * Time.deltaTime;
    }
}
