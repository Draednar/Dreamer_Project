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

    public UnityEvent FirstEvent;

    public UnityEvent MotherInSisterRoomEvent;

    public UnityEvent MasterAndSisterRoom;


    public UnityEvent SisterRoom_Events;
    public UnityEvent MasterRoom_Events;

    public UnityEvent Office_Events;

    public UnityEvent PostChoose_Events;

    public UnityEvent<int> onDoorwayTriggerOpen;

    public UnityEvent<int> onDoorwayTriggerExit;

    public UnityEvent<int> UnlockDoorsItemTaken;

    public UnityEvent<int, bool> AbilitateDoorController;

    public UnityEvent MotherOpeningDoor;

    public UnityEvent SpotMotherTriggerOnEvent;

    public UnityEvent<string, Transform> SpothMotherTriggerOnEventSpawn;


    public UnityEvent FatherChasingStart;

    public UnityEvent SisterShoutingStart;



    public UnityEvent WalkingUncle;

    public UnityEvent DancingLights;

    public UnityEvent UncleChasingStart;

    public UnityEvent OfficeRoom;

    public UnityEvent SisterDeath;

    public UnityEvent Spawn_Mother;
    public UnityEvent Follow_Mother_Event;
    public UnityEvent DeSpawn_Mother;

    public UnityEvent Spawn_Father;
    public UnityEvent Follow_Father_Event;
    public UnityEvent DeSpawn_Father;

    public UnityEvent Spawn_Uncle;
    public UnityEvent Follow_Uncle_Event;
    public UnityEvent DeSpawn_Uncle;


}
