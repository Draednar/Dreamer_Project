using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DoorController : MonoBehaviour
{
    [SerializeField] private Door doorObject;
    [SerializeField] private int id;
    [SerializeField] private bool lockAfterUse;

    public void OnTriggerEnter(Collider other)
    {
        EventMng.current.onDoorwayTriggerOpen.Invoke(id);
    }

    private void OnTriggerExit(Collider other)
    {
        EventMng.current.onDoorwayTriggerExit.Invoke(id);
        if (lockAfterUse)
            this.GameObject().SetActive(false);
    }
}
