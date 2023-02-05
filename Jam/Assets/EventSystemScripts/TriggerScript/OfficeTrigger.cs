using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OfficeTrigger : MonoBehaviour
{

    [SerializeField] public GameObject copy;
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Office Enter");
        
        EventMng.current.DeSpawn_Mother.Invoke();
        EventMng.current.DeSpawn_Father.Invoke();
        EventMng.current.Office_Events.Invoke();

        gameObject.SetActive(false);
        copy.SetActive(false);
    }
}
