using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move1 : MonoBehaviour
{
    [SerializeField] public Transform position;
    private void OnTriggerEnter(Collider other)
    {
        PositionMngr.SetSpawnPosition(position);
        EventMng.current.MoveTo_Uncle_Event.Invoke();
    }
}
