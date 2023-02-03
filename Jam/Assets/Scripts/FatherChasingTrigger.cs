using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FatherChasingTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        EventMng.current.FatherChasingStart.Invoke();
    }

}
