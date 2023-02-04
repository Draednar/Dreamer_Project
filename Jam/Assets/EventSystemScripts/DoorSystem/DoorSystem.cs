using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorSystem : MonoBehaviour
{
    public void Open()
    {
        GetComponent<Animator>().SetBool("Door", true);
    }
    public void Close()
    {
        GetComponent<Animator>().SetBool("Door", false);
    }

    public void RemainOpen()
    {
        transform.Rotate(new Vector3(0f, 90f, 0f), Space.World);
    }
    public void RemainClose()
    {
        transform.Rotate(new Vector3(0f, -90f, 0f), Space.World);
    }
}
