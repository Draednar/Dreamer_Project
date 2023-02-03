using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FatherChasingTrigger : MonoBehaviour
{
    [SerializeField] public Transform position;

    private void OnTriggerEnter(Collider other)
    {
        PositionMngr.SetSpawnPosition(position);
        EventMng.current.FatherChasingStart.Invoke();
    }

}
