using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EventMng : MonoBehaviour
{
    public static EventMng current;


    void Awake()
    {
        current = this;
    }

    public UnityEvent<int> onDoorwayTriggerOpen;

    public UnityEvent<int> onDoorwayTriggerExit;

    public UnityEvent MotherInSisterRoomEvent;

    public UnityEvent MasterAndSisterRoom;

    public UnityEvent WalkingUncle;

    public UnityEvent DancingLights;

}
