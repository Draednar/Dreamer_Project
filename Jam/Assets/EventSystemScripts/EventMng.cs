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

    #region FirstHouse
    public UnityEvent endLoop;

    public UnityEvent FirstEvent;

    public UnityEvent MotherInSisterRoomEvent;

    public UnityEvent MasterAndSisterRoom;


    public UnityEvent SisterRoom_Events;
    public UnityEvent MasterRoom_Events;

    public UnityEvent Office_Events;

    public UnityEvent PostChoose_Events;

    public UnityEvent ActiveOffice_Events;
    public UnityEvent EnterOffice_Events;
    public UnityEvent ExitOffice_UncleFollow_Event;

    public UnityEvent SisterDeath_Event;
    public UnityEvent SisterDeathSceneActive_Event;
    public UnityEvent SisterDeathSceneDisable_Event;

    public UnityEvent OfficeOpenRandom;
    public UnityEvent BedRoomOpenRandom;
    public UnityEvent UncleDeath;

    #endregion


    public UnityEvent Spawn_Mother;
    public UnityEvent Follow_Mother_Event;
    public UnityEvent MoveTo_Mother_Event;
    public UnityEvent DeSpawn_Mother;
    public UnityEvent Idle_Mother;

    public UnityEvent Spawn_Father;
    public UnityEvent Follow_Father_Event;
    public UnityEvent DeSpawn_Father;

    public UnityEvent Spawn_Uncle;
    public UnityEvent Follow_Uncle_Event;
    public UnityEvent MoveTo_Uncle_Event;
    public UnityEvent DeSpawn_Uncle;

    public UnityEvent EnterOffice_UncleFollow_Event;

    public UnityEvent Spawn_Sister;

    public UnityEvent DisableAll;

    public UnityEvent CloseDoor;
}
