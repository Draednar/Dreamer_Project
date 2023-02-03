using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    [SerializeField] private Animator myDoor = null;
    [SerializeField] private int id;
    [SerializeField] public bool isLocked;

    private void Awake()
    {
        DoorsMng.doors.Add(id, this);
    }

    public void OnDoorWayOpen()
    {
        if(!isLocked)
            myDoor.SetBool("OpenDoorState", true);
           
    }

    public void OnDoorWayClose()
    {
            myDoor.SetBool("OpenDoorState", false);
    }

    public void ResetLoop()
    {
        OnDoorWayClose();
    }

}
