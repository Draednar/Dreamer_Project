using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomToExplore : MonoBehaviour
{
    [SerializeField] private int doorIndex;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            EventMng.current.AbilitateDoorController.Invoke(doorIndex, true);
            GameMng.choiceIndex = doorIndex;
            if(doorIndex==0)
                FindObjectOfType<FatherChasingTrigger>().GetComponent<Collider>().enabled = true;
            else if (doorIndex==1)
                FindObjectOfType<SisterShoutingTrigger>().GetComponent<Collider>().enabled = true;
            enabled= false;
        }
    }
}
