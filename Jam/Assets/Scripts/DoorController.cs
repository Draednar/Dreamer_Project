using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DoorController : MonoBehaviour
{
    [SerializeField] private int id;
    [SerializeField] private bool lockAfterUse;

    private void Awake()
    {
        DoorsMng.doorControllers.Add(id, this);
    }

    public void OnTriggerEnter(Collider other)
    {
        EventMng.current.onDoorwayTriggerOpen.Invoke(id);
    }

    private void OnTriggerExit(Collider other)
    {
        EventMng.current.onDoorwayTriggerExit.Invoke(id);
        if (lockAfterUse)
        {
            //this.GameObject().SetActive(false);
            DoorsMng.LockDoor(id);
        }
    }

    public void activateDoorController(bool state)
    {
        GetComponent<BoxCollider>().enabled = state;
    }

}
