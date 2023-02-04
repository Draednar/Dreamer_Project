using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DespawnMother : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {      
        EventMng.current.DeSpawn_Mother.Invoke();
    }
}
