using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpotMotherTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Spawn Mother");
        EventMng.current.MotherInSisterRoomEvent.Invoke();
    }
}
