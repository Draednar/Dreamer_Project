using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour
{
    [SerializeField] float move_speed = 100f, horizontal_mouse_speed = 100f, vertical_mouse_speed = 100, anim_speed = 5f;
    [SerializeField] GameObject main_camera;
    [SerializeField] AnimationCurve curve;

    Player_Input input;
    Rigidbody rb;
    Vector3 direction, rotation;

    float time_animation = 0;

    void Start()
    {
        input = GetComponent<Player_Input>();
        rb = GetComponent<Rigidbody>();
        rotation = main_camera.transform.eulerAngles;
    }



    private void FixedUpdate()
    {
        UseInputs();
        AnimCurveRotate();
    }

    void UseInputs()
    {
        rotation += new Vector3(-input.mouse_rotation.y * horizontal_mouse_speed, input.mouse_rotation.x * vertical_mouse_speed, 0f) * Time.deltaTime;

        main_camera.transform.eulerAngles = rotation;

        direction = transform.forward * input.movement_direction.y + transform.right * input.movement_direction.x;

        rb.velocity = (direction * move_speed) * Time.deltaTime;
    }

    void AnimCurveRotate()
    {
        if (input.movement_direction.x != 0 && input.movement_direction.y != 0)
        {
            time_animation += anim_speed;
        }

        else
        {
            time_animation = 0;
        }

        main_camera.transform.eulerAngles = new Vector3(main_camera.transform.eulerAngles.x, main_camera.transform.eulerAngles.y, curve.Evaluate(time_animation));
    }



}