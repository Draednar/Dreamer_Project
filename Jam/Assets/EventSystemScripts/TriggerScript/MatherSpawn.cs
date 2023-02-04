using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MatherSpawn : MonoBehaviour
{
    [SerializeField] public Transform position;
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Mother Spawn");
        PositionMngr.SetSpawnPosition(position);
        EventMng.current.Spawn_Mother.Invoke();
        EventMng.current.Follow_Mother_Event.Invoke();
    }
}
