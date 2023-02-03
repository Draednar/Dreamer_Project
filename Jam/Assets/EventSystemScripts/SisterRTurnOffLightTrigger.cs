using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SisterRTurnOffLightTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        EventMng.current.SisterDeath.Invoke();
    }
}
