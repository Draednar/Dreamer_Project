using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UncleSpawnRinghiera : MonoBehaviour
{
    [SerializeField] public Transform position;
    [SerializeField] public Transform target;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Uncle Spawn");
        PositionMngr.SetSpawnPosition(position);
        EventMng.current.Spawn_Uncle.Invoke();


        PositionMngr.SetSpawnPosition(target);
        EventMng.current.MoveTo_Uncle_Event.Invoke();

    }
}
