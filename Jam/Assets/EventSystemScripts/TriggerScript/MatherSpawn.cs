using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MatherSpawn : MonoBehaviour
{
    [SerializeField] public Transform position;
    [SerializeField] public GameObject copy;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Mother Spawn");
        PositionMngr.SetSpawnPosition(position);
        EventMng.current.Spawn_Mother.Invoke();

        EventMng.current.MoveTo_Mother_Event.Invoke();

        gameObject.SetActive(false);
        copy.SetActive(false);
    }
}
