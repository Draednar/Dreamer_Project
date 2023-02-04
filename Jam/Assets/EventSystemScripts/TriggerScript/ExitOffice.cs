using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitOffice : MonoBehaviour
{
    [SerializeField] public Transform position;
    private void OnTriggerEnter(Collider other)
    {
        EventMng.current.ExitOffice_UncleFollow_Event.Invoke();
        PositionMngr.SetSpawnPosition(position);
        EventMng.current.Spawn_Uncle.Invoke();
        EventMng.current.Follow_Uncle_Event.Invoke();
    }
}
