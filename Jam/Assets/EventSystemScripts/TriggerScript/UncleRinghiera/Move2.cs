using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move2 : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        EventMng.current.DeSpawn_Uncle.Invoke();
    }
}
