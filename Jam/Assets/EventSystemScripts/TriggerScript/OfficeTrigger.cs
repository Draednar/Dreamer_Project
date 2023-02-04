using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OfficeTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Office Enter");
        
        EventMng.current.DeSpawn_Mother.Invoke();
        EventMng.current.DeSpawn_Father.Invoke();
    }
}
