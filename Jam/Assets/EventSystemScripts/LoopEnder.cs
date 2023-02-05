using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopEnder : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        EventMng.current.CloseDoor.Invoke();
        //EventMng.current.DisableAll.Invoke();
        EventMng.current.endLoop.Invoke();
    }
}
