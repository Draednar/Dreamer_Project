using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UncleChasingTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        EventMng.current.UncleChasingStart.Invoke() ;
    }
}
