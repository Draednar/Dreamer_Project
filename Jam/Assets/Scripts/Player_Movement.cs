using FMODUnity;
using System;
using UnityEngine;

public class Player_Movement : MonoBehaviour
{
    [SerializeField] float move_speed = 100f, horizontal_mouse_speed = 100f, vertical_mouse_speed = 100, anim_speed = 0.1f, z_rotation;
    [SerializeField] GameObject main_camera, text;
    [SerializeField] AnimationCurve curve;

    Transform trigger_1, trigger_2, interracted;

    public delegate void OnSwitchMap();
    public static event OnSwitchMap change;

    public delegate void OnResetDoor();
    public static event OnResetDoor reset;

    Player_Input input;
    Rigidbody rb;
    bool active = false;
    Vector3 direction, rotation;

    float time_animation = 0;

    void Start()
    {
        input = GetComponent<Player_Input>();
        rb = GetComponent<Rigidbody>();
        rotation = transform.eulerAngles;
    }

    private void Update()
    {
        UseRotation();
        AnimCurveRotate();
    }

    private void FixedUpdate()
    {
        UseMovement();
        CheckInteractable();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Switch" && trigger_1 != other.transform || trigger_1 == null)
        {
            trigger_1 = other.transform;
            change.Invoke();
        }

        else if (other.tag == "Reset" && trigger_2 != other.transform || trigger_2 == null)
        {
            trigger_2 = other.transform;
            reset.Invoke();
        }
    }

    void UseMovement()
    {
        direction = transform.forward * input.movement_direction.y + transform.right * input.movement_direction.x;

        rb.velocity = (direction * move_speed) * Time.deltaTime;

        PlayStep();
    }

    private void PlayStep()
    {
        if (Math.Abs(curve.Evaluate(time_animation)) == 1)
        {
            SoundMgr.PlaySound("Step");
        }
    }

    void UseRotation()
    {
        rotation += new Vector3(-input.mouse_rotation.y * horizontal_mouse_speed, input.mouse_rotation.x * vertical_mouse_speed, 0f) * Time.deltaTime;

        transform.eulerAngles = rotation;
    }

    void AnimCurveRotate()
    {
        if (input.movement_direction.x != 0 || input.movement_direction.y != 0)
        {
            time_animation += anim_speed;
            main_camera.transform.localEulerAngles = new Vector3(main_camera.transform.localEulerAngles.x, main_camera.transform.localEulerAngles.y, curve.Evaluate(time_animation) * z_rotation);
        }

        else
        {
            time_animation = 0;
            main_camera.transform.localEulerAngles = new Vector3(main_camera.transform.localEulerAngles.x, main_camera.transform.localEulerAngles.y, Mathf.LerpAngle(main_camera.transform.localEulerAngles.z, 0f, 1f * Time.deltaTime));
        }
    }

    void CheckInteractable()
    {
        Ray ray = Camera.main.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0f));
        
        RaycastHit hit;

        text.SetActive(false);

        if (Physics.Raycast(ray, out hit, 1f))
        {
            IInteractable interact = hit.transform.GetComponent<IInteractable>();

            if (interact != null)
            {
                if (input.button_interact && interracted != hit.transform || interracted == null)
                {
                    interracted = hit.transform;
                    interact.Interact();
                }
                text.SetActive(true);
            }
        }
    }

}