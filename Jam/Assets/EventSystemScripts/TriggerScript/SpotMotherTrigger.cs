using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpotMotherTrigger : MonoBehaviour
{
    [SerializeField] public Transform position; 
    [SerializeField] public Transform destination;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Spawn Mother");
        PositionMngr.SetSpawnPosition(position);
        PositionMngr.SetRotation(new Vector3(0f, -90f, 0f));
        EventMng.current.Spawn_Mother.Invoke();
        //EventMng.current.SpothMotherTriggerOnEventSpawn.Invoke("Mother", position);
        PositionMngr.SetTargetPosition(destination);
        EventMng.current.MotherInSisterRoomEvent.Invoke();
    }
}
