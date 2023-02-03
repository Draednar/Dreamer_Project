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

    public UnityEvent endLoop;

    public UnityEvent<int> onDoorwayTriggerOpen;

    public UnityEvent<int> onDoorwayTriggerExit;

    public UnityEvent<int> UnlockDoorsItemTaken;

    public UnityEvent<int, bool> AbilitateDoorController;

    public UnityEvent MotherOpeningDoor;

    public UnityEvent SpotMotherTriggerOnEvent;

    public UnityEvent<string, Transform> SpothMotherTriggerOnEventSpawn;


    public UnityEvent FatherChasingStart;

    public UnityEvent SisterShoutingStart;

    public UnityEvent MotherInSisterRoomEvent;

    public UnityEvent MasterAndSisterRoom;

    public UnityEvent WalkingUncle;

    public UnityEvent DancingLights;

    public UnityEvent UncleChasingStart;

    public UnityEvent OfficeRoom;

    public UnityEvent SisterDeath;
}
