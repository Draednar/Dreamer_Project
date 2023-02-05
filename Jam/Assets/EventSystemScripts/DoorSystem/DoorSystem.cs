using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorSystem : MonoBehaviour
{
    public void Open()
    {
        GetComponent<Animator>().SetBool("OpenDoor", true);
    }
    public void Close()
    {
        GetComponent<Animator>().SetBool("OpenDoor", false);
    }
    
}
