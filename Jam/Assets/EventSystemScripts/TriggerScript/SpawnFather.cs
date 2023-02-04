using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnFather : MonoBehaviour
{
    [SerializeField] public Transform position;
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Father Spawn");
        PositionMngr.SetSpawnPosition(position);
        EventMng.current.Spawn_Father.Invoke();
        EventMng.current.Follow_Father_Event.Invoke();
    }
}
