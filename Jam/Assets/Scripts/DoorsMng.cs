using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorsMng : MonoBehaviour
{
    public static Dictionary<int, Door> doors = new Dictionary<int, Door>();

    public static void OpenDoor(int id)
    {
        doors[id].OnDoorWayOpen();
    }

    public static void CloseDoor(int id)
    {
        doors[id].OnDoorWayClose();
    }
}
