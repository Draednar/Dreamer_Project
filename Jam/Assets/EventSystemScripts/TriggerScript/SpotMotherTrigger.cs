using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpotMotherTrigger : MonoBehaviour
{
    [SerializeField] private GameObject obj;
    [SerializeField] public GameObject copy;

    private void OnTriggerEnter(Collider other)
    {
        obj.SetActive(true);
        obj.GetComponent<Animator>().SetBool("OpenDoor", true);
        EventMng.current.MotherInSisterRoomEvent.Invoke();

        gameObject.SetActive(false);
        copy.SetActive(false);
    }
}
