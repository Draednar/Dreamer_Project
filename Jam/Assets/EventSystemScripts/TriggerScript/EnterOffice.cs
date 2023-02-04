using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnterOffice : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {        
        EventMng.current.EnterOffice_UncleFollow_Event.Invoke();
    }
}
