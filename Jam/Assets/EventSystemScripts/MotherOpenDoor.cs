using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MotherOpenDoor : MonoBehaviour
{
   
    public void OpenDoor()
    {
        EventMng.current.MotherOpeningDoor.Invoke();
    }

}
