using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorsMng : MonoBehaviour
{
    public static Dictionary<int, Door> doors = new Dictionary<int, Door>();
    public static Dictionary<int, DoorController> doorControllers = new Dictionary<int, DoorController>();

    public static void OpenDoor(int id)
    {
        doors[id].OnDoorWayOpen();
    }

    public static void CloseDoor(int id)
    {
        doors[id].OnDoorWayClose();
    }

    public static void LockDoor(int id)
    {
        doors[id].GetComponent<BoxCollider>().enabled = false;
        doors[id].isLocked= true;
    }
    public static void UnlockDoor(int id)
    {
        doors[id].GetComponent<BoxCollider>().gameObject.SetActive(true);
        doors[id].isLocked = false;
    }

    public static void ActivateDoorController(int id, bool state)
    {
        //Per chiarezza: false=chiusa, true = aperta
        doorControllers[id].activateDoorController(state);
    }
  
}
