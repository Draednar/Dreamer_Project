using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SisterDeathScene : MonoBehaviour
{
    [SerializeField] public Transform positionMother;
    [SerializeField] public Transform positionSister;
    private void OnTriggerEnter(Collider other)
    {
        SpawnSister();
        SpawnMother();
        EventMng.current.SisterDeathSceneActive_Event.Invoke();
    }



    private void SpawnSister()
    {
        PositionMngr.SetSpawnPosition(positionSister);
        EventMng.current.Spawn_Sister.Invoke();
    }
    private void SpawnMother()
    {
        PositionMngr.SetSpawnPosition(positionMother);
        EventMng.current.Spawn_Mother.Invoke();
        EventMng.current.Idle_Mother.Invoke();
    }
}
