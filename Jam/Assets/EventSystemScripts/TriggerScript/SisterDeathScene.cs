using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SisterDeathScene : MonoBehaviour
{
    [SerializeField] public Transform positionMother;
    [SerializeField] public Transform positionSister;
    [SerializeField] GameObject GameMngr;

    [SerializeField] public GameObject copy;
    private void OnTriggerEnter(Collider other)
    {
        SpawnSister();
        SpawnMother();
        GameMngr.GetComponent<LightBlink>().AllOff();
        EventMng.current.SisterDeathSceneActive_Event.Invoke();

        gameObject.SetActive(false);
        copy.SetActive(false);
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
