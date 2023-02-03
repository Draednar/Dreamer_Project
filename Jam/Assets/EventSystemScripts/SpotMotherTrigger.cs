using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpotMotherTrigger : MonoBehaviour
{
    [SerializeField] public Transform position; 

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Spawn Mother");
        PositionMngr.SetSpawnPosition(position);
        //EventMng.current.SpothMotherTriggerOnEventSpawn.Invoke("Mother", position);
        EventMng.current.MotherInSisterRoomEvent.Invoke();
    }
}
